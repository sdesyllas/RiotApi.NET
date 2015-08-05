using System;
using System.Configuration;
using System.Linq;
using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class RiotHttpClientTests
    {
        /// <summary>
        /// IOC (Inversion of Control) container
        /// https://en.wikipedia.org/wiki/Inversion_of_control
        /// </summary>
        private static IContainer Container { get; set; }
        private static ILifetimeScope Scope { get; set; }

        [TestFixtureSetUp]
        public void Init()
        {
            // Create your builder.
            var builder = new ContainerBuilder();
            // Register individual components
            builder.RegisterInstance(new RiotHttpClient(ConfigurationManager.AppSettings["ApiKey"])).As<IRiotClient>();
            Container = builder.Build();
            Scope = Container.BeginLifetimeScope();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Scope.Dispose();
        }

        [Test]
        public void GetAllChampions()
        {
            var api = Scope.Resolve<IChampion>();
            var dto = api.RetrieveAllChampions(RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            Assert.Greater(dto.Champions.Count(), 0);
            foreach (var championDto in dto.Champions)
            {
                Console.WriteLine(championDto.ToString());
            }
        }

        [Test]
        public void GetChampionById()
        {
            var api = Scope.Resolve<IRiotClient>();
            var dto = api.Champion.RetrieveChampionById(RiotApiConfig.Regions.EUNE, 1);
            Assert.NotNull(dto);
            Assert.AreEqual(1, dto.Id);
            Console.WriteLine(dto.ToString());
        }

        [Test]
        public void Example1()
        {
            //initialize riot http client with your riot api key
            IRiotClient riotClient = new RiotHttpClient("your api key here");
            //retrieve all current free to play champions
            var championList = riotClient.Champion.RetrieveAllChampions(RiotApiConfig.Regions.NA, freeToPlay: true);
            //print the number of free to play champions
            Console.WriteLine($"There are {championList.Champions.Count()} free to play champions to play with!");
        }
    }
}
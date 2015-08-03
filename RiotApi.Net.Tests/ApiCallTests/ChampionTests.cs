using System;
using System.Configuration;
using System.Linq;
using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class ChampionTests
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
            builder.RegisterInstance(new Champion(ConfigurationManager.AppSettings["ApiKey"])).As<IChampion>();
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
            var api = Scope.Resolve<IChampion>();
            var dto = api.RetrieveChampionById(RiotApiConfig.Regions.EUNE, 1);
            Assert.NotNull(dto);
            Assert.AreEqual(1, dto.Id);
            Console.WriteLine(dto.ToString());
        }
    }
}
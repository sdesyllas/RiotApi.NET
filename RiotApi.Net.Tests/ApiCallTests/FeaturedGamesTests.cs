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
    public class FeaturedGamesTests
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
            builder.RegisterInstance(new FeaturedGames(ConfigurationManager.AppSettings["ApiKey"])).As<IFeaturedGames>();
            Container = builder.Build();
            Scope = Container.BeginLifetimeScope();
            Scope.Resolve<IFeaturedGames>();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Scope.Dispose();
        }

        [Test]
        public void GetAllFeaturedGames()
        {
            var api = Scope.Resolve<IFeaturedGames>();
            var dto = api.GetListOfFeaturedGames(RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            Assert.Greater(dto.GameList.Count(), 0);
            foreach (var game in dto.GameList)
            {
                Console.WriteLine("======");
                Console.WriteLine(game.ToString());
            }
        }
    }
}

using System;
using System.Configuration;
using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class SummonerTests
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
            builder.RegisterInstance(new Summoner(ConfigurationManager.AppSettings["ApiKey"])).As<ISummoner>();
            Container = builder.Build();
            Scope = Container.BeginLifetimeScope();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Scope.Dispose();
        }

        [Test]
        public void GetSummonersByName()
        {
            var api = Scope.Resolve<ISummoner>();
            var dto = api.GetSummonersByName(RiotApiConfig.Regions.EUNE, "Xeyanord", "Onesa");
            Assert.NotNull(dto);
            Assert.AreEqual(2, dto.Keys.Count);
            foreach (var summoner in dto.Values)
            {
                Console.WriteLine(summoner.ToString());
            }
        }

        [Test]
        public void GetSummonersById()
        {
            var api = Scope.Resolve<ISummoner>();
            var dto = api.GetSummonersById(RiotApiConfig.Regions.EUNE, "41488614", "41468510");
            Assert.NotNull(dto);
            Assert.AreEqual(2, dto.Keys.Count);
            foreach (var summoner in dto.Values)
            {
                Console.WriteLine(summoner.ToString());
            }
        }

        [Test]
        public void GetMasteryPagesBySummonerId()
        {
            var api = Scope.Resolve<ISummoner>();
            var dto = api.GetMasteryPagesBySummonerId(RiotApiConfig.Regions.EUNE, "41488614", "41468510");
            Assert.NotNull(dto);
            Assert.AreEqual(2, dto.Keys.Count);
            foreach (var summoner in dto.Values)
            {
                Console.WriteLine(summoner.ToString());
            }
        }

        [Test]
        public void GetSummonerNamesBySummonerId()
        {
            var api = Scope.Resolve<ISummoner>();
            var dto = api.GetSummonerNamesBySummonerId(RiotApiConfig.Regions.EUNE, "41488614", "41468510");
            Assert.NotNull(dto);
            Assert.AreEqual(2, dto.Keys.Count);
            foreach (var summoner in dto.Values)
            {
                Console.WriteLine(summoner.ToString());
            }
        }

        [Test]
        public void GetRunePagesBySummonerId()
        {
            var api = Scope.Resolve<ISummoner>();
            var dto = api.GetRunePagesBySummonerId(RiotApiConfig.Regions.EUNE, "41488614", "41468510");
            Assert.NotNull(dto);
            Assert.AreEqual(2, dto.Keys.Count);
            foreach (var summoner in dto.Values)
            {
                Console.WriteLine(summoner.ToString());
            }
        }
    }
}
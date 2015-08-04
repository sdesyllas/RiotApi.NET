using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.LolStatus;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class LolStatusTests
    {
        /// <summary>
        /// IOC (Inversion of Control) container
        /// https://en.wikipedia.org/wiki/Inversion_of_control
        /// </summary>
        private static IContainer Container { get; set; }

        private static ILifetimeScope Scope { get; set; }
        public object RiotApiConfig { get; private set; }

        [TestFixtureSetUp]
        public void Init()
        {
            // Create your builder.
            var builder = new ContainerBuilder();
            // Register individual components
            builder.RegisterInstance(new LolStatus()).As<ILolStatus>();
            Container = builder.Build();
            Scope = Container.BeginLifetimeScope();
            Scope.Resolve<ILolStatus>();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Scope.Dispose();
        }

        [Test]
        public void GetShards()
        {
            var api = Scope.Resolve<ILolStatus>();
            var dto = api.GetShards();
            Assert.NotNull(dto);
            var shardDtos = dto as IList<ShardDto> ?? dto.ToList();
            Assert.Greater(shardDtos.Count(), 0);
            foreach (var shard in shardDtos)
            {
                Console.WriteLine(shard);
            }
        }

        [TestCase(RestClient.Configuration.RiotApiConfig.Regions.EUNE)]
        [TestCase(RestClient.Configuration.RiotApiConfig.Regions.BR)]
        [TestCase(RestClient.Configuration.RiotApiConfig.Regions.EUW)]
        [TestCase(RestClient.Configuration.RiotApiConfig.Regions.LAN)]
        [TestCase(RestClient.Configuration.RiotApiConfig.Regions.LAS)]
        [TestCase(RestClient.Configuration.RiotApiConfig.Regions.NA)]
        [TestCase(RestClient.Configuration.RiotApiConfig.Regions.OCE)]
        [TestCase(RestClient.Configuration.RiotApiConfig.Regions.RU)]
        [TestCase(RestClient.Configuration.RiotApiConfig.Regions.TR)]
        public void GetShardStatusByRegion(RiotApiConfig.Regions region)
        {
            var api = Scope.Resolve<ILolStatus>();
            var dto = api.GetShardStatusByRegion(region);
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
        [Test]
        public void GetShards()
        {
            var dto = GlobalSetup.RiotClient.LolStatus.GetShards();
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
            var dto = GlobalSetup.RiotClient.LolStatus.GetShardStatusByRegion(region);
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }
    }
}

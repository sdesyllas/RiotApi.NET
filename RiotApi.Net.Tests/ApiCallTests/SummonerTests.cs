using System;
using System.Configuration;
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
        [Test]
        public void GetSummonersByName()
        {
            var dto = GlobalSetup.RiotHttpClient.Summoner.GetSummonersByName(RiotApiConfig.Regions.EUNE, "Xeyanord", "Onesa");
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
            var dto = GlobalSetup.RiotHttpClient.Summoner.GetSummonersById(RiotApiConfig.Regions.EUNE, "41488614", "41468510");
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
            var dto = GlobalSetup.RiotHttpClient.Summoner.GetMasteryPagesBySummonerId(RiotApiConfig.Regions.EUNE, "41488614", "41468510");
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
            var dto = GlobalSetup.RiotHttpClient.Summoner.GetSummonerNamesBySummonerId(RiotApiConfig.Regions.EUNE, "41488614", "41468510");
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
            var dto = GlobalSetup.RiotHttpClient.Summoner.GetRunePagesBySummonerId(RiotApiConfig.Regions.EUNE, "41488614", "41468510");
            Assert.NotNull(dto);
            Assert.AreEqual(2, dto.Keys.Count);
            foreach (var summoner in dto.Values)
            {
                Console.WriteLine(summoner.ToString());
            }
        }
    }
}
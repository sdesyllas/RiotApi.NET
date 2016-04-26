using System;
using System.Configuration;
using System.Linq;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class ChampionMasteryTests
    {
        [Test]
        public void RetrieveChampionMasteryByID()
        {
            var dto = GlobalSetup.RiotHttpClient.ChampionMastery.RetrieveChampionMasteryByID(RiotApiConfig.Regions.NA, 19805690, 1);
            Assert.NotNull(dto);
            Console.WriteLine(dto.ToString());
        }
        [Test]
        public void RetrieveChampionMasteriesByPlayerId()
        {
            var dto = GlobalSetup.RiotHttpClient.ChampionMastery.RetrieveChampionMasteriesByPlayerId(RiotApiConfig.Regions.NA, 19805690);
            Assert.NotNull(dto);
            foreach(var cm in dto)
            {
                Console.WriteLine(cm.ToString());
            }
            

        }
        [Test]
        public void RetrieveChampionMasterScore()
        {
            var score = GlobalSetup.RiotHttpClient.ChampionMastery.RetrieveChampionMasterScore(RiotApiConfig.Regions.NA, 19805690);
            Assert.Greater(score, 0);
        }
        [Test]
        public void RetrieveTopChampions()
        {
            var dto = GlobalSetup.RiotHttpClient.ChampionMastery.RetrieveTopChampions(RiotApiConfig.Regions.NA, 19805690,5);
            Assert.AreEqual(dto.ToList().Count, 5);
            foreach (var cm in dto)
            {
                Console.WriteLine(cm.ToString());
            }
        }

    }
}

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
    public class FeaturedGamesTests
    {
        [Test]
        public void GetAllFeaturedGames()
        {
            var dto = GlobalSetup.RiotClient.FeaturedGames.GetListOfFeaturedGames(RiotApiConfig.Regions.EUNE);
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
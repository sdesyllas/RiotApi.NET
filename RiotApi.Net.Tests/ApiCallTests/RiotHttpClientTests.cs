using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Ninject;
using NUnit.Framework;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Stats;
using RiotApi.Net.RestClient.Dto.Summoner;
using RiotApi.Net.RestClient.Helpers;
using RiotHttpClientModule = RiotApi.Net.Tests.NinjectModules.RiotHttpClientModule;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class RiotHttpClientTests
    {

        [Test]
        public void GetAllChampions()
        {
            var dto = GlobalSetup.RiotHttpClient.Champion.RetrieveAllChampions(RiotApiConfig.Regions.EUNE);
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
            var dto = GlobalSetup.RiotHttpClient.Champion.RetrieveChampionById(RiotApiConfig.Regions.EUNE, 1);
            Assert.NotNull(dto);
            Assert.AreEqual(1, dto.Id);
            Console.WriteLine(dto.ToString());
        }

        [Test]
        [ExpectedException(typeof(RiotExceptionRaiser.RiotApiException))]
        public void TestUnauthorized()
        {
            //initialize riot client using http module with a riot api key
            IKernel kernel = new StandardKernel(new RiotHttpClientModule("your api key here"));
            //get back your riotClient initialised with http module by ninject
            var riotClient = kernel.Get<RiotClient>();
            //retrieve all current free to play champions
            var championList = riotClient.Champion.RetrieveAllChampions(RiotApiConfig.Regions.NA, freeToPlay: true);
            //print the number of free to play champions
            Console.WriteLine($"There are {championList.Champions.Count()} free to play champions to play with!");
        }

        [Test]
        public void TestNinject()
        {
            //initialize riot client injecting http modules with your riot api key
            IKernel kernel = new StandardKernel(new RiotHttpClientModule(ConfigurationManager.AppSettings["ApiKey"]));
            var riotClient = kernel.Get<RiotClient>();
            //retrieve all current free to play champions
            var championList = riotClient.Champion.RetrieveAllChampions(RiotApiConfig.Regions.NA, freeToPlay: true);
            //print the number of free to play champions
            Console.WriteLine($"There are {championList.Champions.Count()} free to play champions to play with!");
        }

        public void Example1()
        {
            IRiotClient riotClient = new RiotClient("your api key here");
            //retrieve all current free to play champions
            var championList = riotClient.Champion.RetrieveAllChampions(RiotApiConfig.Regions.NA, freeToPlay: true);
            //print the number of free to play champions
            Console.WriteLine($"There are {championList.Champions.Count()} free to play champions to play with!");
        }

        [Test]
        public void Example2()
        {
            IRiotClient riotClient = new RiotClient("your api key here");
            //retrieve xeyanord and fnatictop summoners with one call
            var summoners = riotClient.Summoner.GetSummonersByName(RiotApiConfig.Regions.EUNE, "xeyanord", "fnatictop");
            var xeyanord = summoners["xeyanord"];
            var fnatictop = summoners["fnatictop"];
            //print the following statement about the two summoners
            Console.WriteLine(
                $"{fnatictop.Name} is level {fnatictop.SummonerLevel} and {xeyanord.Name} is {xeyanord.SummonerLevel}, its because {xeyanord.Name} is a slacker!");
        }

        [Test]
        public void Example3()
        {
            IRiotClient riotClient = new RiotClient("your api key here");
            //get challeger tier league for ranked solo 5x5
            var challengers = riotClient.League.GetChallengerTierLeagues(RiotApiConfig.Regions.EUNE,
                Enums.GameQueueType.RANKED_SOLO_5x5);
            //get top 5 top leaderboard using LINQ
            var top5 = challengers.Entries.OrderByDescending(x => x.LeaguePoints).Take(5).ToList();
            //Print top 5 leaderboard
            top5.ForEach(
                topEntry =>
                    Console.WriteLine(
                        $"{topEntry.PlayerOrTeamName} - wins:{topEntry.Wins}  loss:{topEntry.Losses} points:{topEntry.LeaguePoints}"));
        }
    }
}
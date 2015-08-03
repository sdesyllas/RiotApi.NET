using System;
using System.Configuration;
using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class LeagueTests
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
            builder.RegisterInstance(new League(ConfigurationManager.AppSettings["ApiKey"])).As<ILeague>();
            Container = builder.Build();
            Scope = Container.BeginLifetimeScope();
            Scope.Resolve<ILeague>();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Scope.Dispose();
        }

        [Test]
        public void GetSummonerLeaguesByIds()
        {
            var api = Scope.Resolve<ILeague>();
            try
            {
                var dto = api.GetSummonerLeaguesByIds(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 22293716,
                    41488614);
                foreach (var league in dto.Keys)
                {
                    Console.WriteLine($"summoner: {league}");
                    var summonerLeagues = dto[league];
                    foreach (var summonerLeague in summonerLeagues)
                    {
                        Console.WriteLine($"league: {summonerLeague.Queue} , {summonerLeague.Tier}");
                        Console.WriteLine(summonerLeague.ToString());
                    }
                }
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                Console.WriteLine($"Summoner has no leagues! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
            }
        }

        [Test]
        public void GetSummonerLeagueEntriesByIds()
        {
            var api = Scope.Resolve<ILeague>();
            try
            {
                var dto = api.GetSummonerLeagueEntriesByIds(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 22293716,
                    41488614);
                foreach (var league in dto.Keys)
                {
                    Console.WriteLine($"summoner: {league}");
                    var summonerLeagues = dto[league];
                    foreach (var summonerLeague in summonerLeagues)
                    {
                        Console.WriteLine($"league: {summonerLeague.Queue} , {summonerLeague.Tier}");
                        Console.WriteLine(summonerLeague.ToString());
                    }
                }
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                Console.WriteLine($"Team has no leagues! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
            }
        }

        [Test]
        public void GetTeamLeaguesbyIds()
        {
            var api = Scope.Resolve<ILeague>();
            try
            {
                var dto = api.GetTeamLeaguesbyIds(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                    "TEAM-18cc5c20-b4f9-11e4-80a9-782bcb46f3e4", "TEAM-b999b8d0-18d8-11e5-8e2b-782bcb46f3e4");
                foreach (var league in dto.Keys)
                {
                    Console.WriteLine($"team: {league}");
                    var teamLeagues = dto[league];
                    foreach (var teamLeague in teamLeagues)
                    {
                        Console.WriteLine($"league: {teamLeague.Queue} , {teamLeague.Tier}");
                        Console.WriteLine(teamLeague.ToString());
                    }
                }
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                Console.WriteLine($"Team has no leagues! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
            }
        }


        [Test]
        public void GetTeamLeagueEntriesbyIds()
        {
            var api = Scope.Resolve<ILeague>();
            try
            {
                var dto = api.GetTeamLeagueEntriesbyIds(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                    "TEAM-18cc5c20-b4f9-11e4-80a9-782bcb46f3e4", "TEAM-b999b8d0-18d8-11e5-8e2b-782bcb46f3e4");
                foreach (var league in dto.Keys)
                {
                    Console.WriteLine($"team: {league}");
                    var teamLeagues = dto[league];
                    foreach (var teamLeague in teamLeagues)
                    {
                        Console.WriteLine($"league: {teamLeague.Queue} , {teamLeague.Tier}");
                        Console.WriteLine(teamLeague.ToString());
                    }
                }
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                Console.WriteLine($"Team has no leagues! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
            }
        }

        [Test]
        public void GetChallengerTierLeagues()
        {
            var api = Scope.Resolve<ILeague>();
            var team5X5Dto = api.GetChallengerTierLeagues(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                Enums.GameQueueType.RANKED_TEAM_5x5);
            Assert.NotNull(team5X5Dto);
            Assert.AreEqual(Enums.GameQueueType.RANKED_TEAM_5x5.ToString(), team5X5Dto.Queue.ToString());
            Console.WriteLine(team5X5Dto);

            var solo5X5Dto = api.GetChallengerTierLeagues(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                Enums.GameQueueType.RANKED_SOLO_5x5);
            Assert.NotNull(solo5X5Dto);
            Assert.AreEqual(Enums.GameQueueType.RANKED_SOLO_5x5.ToString(), solo5X5Dto.Queue.ToString());
            Console.WriteLine(solo5X5Dto);
        }

        [Test]
        public void GetMasterTierLeagues()
        {
            var api = Scope.Resolve<ILeague>();
            var team5X5Dto = api.GetMasterTierLeagues(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                Enums.GameQueueType.RANKED_TEAM_5x5);
            Assert.NotNull(team5X5Dto);
            Assert.AreEqual(Enums.GameQueueType.RANKED_TEAM_5x5.ToString(), team5X5Dto.Queue.ToString());
            Console.WriteLine(team5X5Dto);

            var solo5X5Dto = api.GetMasterTierLeagues(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                Enums.GameQueueType.RANKED_SOLO_5x5);
            Assert.NotNull(solo5X5Dto);
            Assert.AreEqual(Enums.GameQueueType.RANKED_SOLO_5x5.ToString(), solo5X5Dto.Queue.ToString());
            Console.WriteLine(solo5X5Dto);
        }
    }
}
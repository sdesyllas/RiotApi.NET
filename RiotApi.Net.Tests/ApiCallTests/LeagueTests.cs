using System;
using System.Configuration;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class LeagueTests
    {
        [Test]
        public void GetSummonerLeaguesByIds()
        {
            try
            {
                var dto = GlobalSetup.RiotClient.League.GetSummonerLeaguesByIds(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 22293716,
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
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine(
                        $"Summoner has no leagues! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("test error", riotException);
                }
            }
        }

        [Test]
        public void GetSummonerLeagueEntriesByIds()
        {
            try
            {
                var dto = GlobalSetup.RiotClient.League.GetSummonerLeagueEntriesByIds(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 22293716,
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
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine(
                        $"Team has no leagues! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("error", riotException);
                }
            }
        }

        [Test]
        public void GetTeamLeaguesbyIds()
        {
            try
            {
                var dto = GlobalSetup.RiotClient.League.GetTeamLeaguesbyIds(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
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
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine(
                        $"Team has no leagues! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("error", riotException);
                }
            }
        }


        [Test]
        public void GetTeamLeagueEntriesbyIds()
        {
            try
            {
                var dto = GlobalSetup.RiotClient.League.GetTeamLeagueEntriesbyIds(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
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
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine(
                        $"Team has no leagues! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("error", riotException);
                }
            }
        }

        [Test]
        public void GetChallengerTierLeagues()
        {
            var team5X5Dto = GlobalSetup.RiotClient.League.GetChallengerTierLeagues(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                Enums.GameQueueType.RANKED_TEAM_5x5);
            Assert.NotNull(team5X5Dto);
            Assert.AreEqual(Enums.GameQueueType.RANKED_TEAM_5x5.ToString(), team5X5Dto.Queue.ToString());
            Console.WriteLine(team5X5Dto);

            var solo5X5Dto = GlobalSetup.RiotClient.League.GetChallengerTierLeagues(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                Enums.GameQueueType.RANKED_SOLO_5x5);
            Assert.NotNull(solo5X5Dto);
            Assert.AreEqual(Enums.GameQueueType.RANKED_SOLO_5x5.ToString(), solo5X5Dto.Queue.ToString());
            Console.WriteLine(solo5X5Dto);
        }

        [Test]
        public void GetMasterTierLeagues()
        {
            var team5X5Dto = GlobalSetup.RiotClient.League.GetMasterTierLeagues(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                 Enums.GameQueueType.RANKED_TEAM_5x5);
            Assert.NotNull(team5X5Dto);
            Assert.AreEqual(Enums.GameQueueType.RANKED_TEAM_5x5.ToString(), team5X5Dto.Queue.ToString());
            Console.WriteLine(team5X5Dto);

            var solo5X5Dto = GlobalSetup.RiotClient.League.GetMasterTierLeagues(RestClient.Configuration.RiotApiConfig.Regions.EUNE,
                Enums.GameQueueType.RANKED_SOLO_5x5);
            Assert.NotNull(solo5X5Dto);
            Assert.AreEqual(Enums.GameQueueType.RANKED_SOLO_5x5.ToString(), solo5X5Dto.Queue.ToString());
            Console.WriteLine(solo5X5Dto);
        }
    }
}
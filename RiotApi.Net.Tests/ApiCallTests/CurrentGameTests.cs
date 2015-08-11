using System;
using System.Configuration;
using System.Linq;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class CurrentGameTests
    {
        [Test]
        public void GetCurrentGameInformationForSummoner()
        {
            try
            {
                var dto = GlobalSetup.RiotHttpClient.CurrentGame.GetCurrentGameInformationForSummonerId(RiotApiConfig.Platforms.EUN1, 41488614);
                Assert.NotNull(dto);
                Console.WriteLine($"Summoner's current game : {dto.GameId}");
                Console.WriteLine($"Summoner's game mode : {dto.GameMode}");
                Console.WriteLine($"Summoner's game length in seconds : {dto.GameLength}");
                Console.WriteLine(dto.ToString());
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine(
                        $"Summoner is not currently playing any game! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("test error", riotException);
                }
            }
        }
    }
}
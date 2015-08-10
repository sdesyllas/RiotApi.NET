using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;
using System;
using System.Configuration;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void GetRecentGamesBySummonerId()
        {
            try
            {
                var dto = GlobalSetup.RiotClient.Game.GetRecentGamesBySummonerId(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 41488614);
                Assert.NotNull(dto);
                Console.WriteLine($"Summoner: {dto.SummonerId}");
                foreach(var game in dto.Games)
                {
                    Assert.IsNotNull(game);
                }
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

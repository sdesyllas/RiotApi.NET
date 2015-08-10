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
    public class MatchHistoryTests
    {
        [TestCase(41488614)]
        [TestCase(22293716)]
        public void GetMatchHistoryBySummonerId(long summonerId)
        {
            try
            {
                var dto = GlobalSetup.RiotClient.MatchHistory.GetMatchHistoryBySummonerId(RiotApiConfig.Regions.EUNE, summonerId);
                Assert.NotNull(dto);
                Console.WriteLine(dto.ToString());
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine($"Match not found : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("test exception", riotException);
                }
            }
        }
    }
}
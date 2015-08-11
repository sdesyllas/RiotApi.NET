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
    public class StatsTests
    {
        [TestCase(41488614)]
        [TestCase(22293716)]
        public void GetRankedStatsBySummonerId(long summonerId)
        {
            try
            {
                var dto = GlobalSetup.RiotHttpClient.Stats.GetRankedStatsBySummonerId(RiotApiConfig.Regions.EUNE, summonerId);
                Assert.NotNull(dto);
                Assert.AreEqual(summonerId, dto.SummonerId);
                Console.WriteLine(dto.ToString());
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine($"stats not found : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("test exception", riotException);
                }
            }
        }

        [TestCase(41488614)]
        [TestCase(22293716)]
        public void GetPlayerStatsBySummonerId(long summonerId)
        {
            try
            {
                var dto = GlobalSetup.RiotHttpClient.Stats.GetPlayerStatsBySummonerId(RiotApiConfig.Regions.EUNE, summonerId);
                Assert.NotNull(dto);
                Assert.AreEqual(summonerId, dto.SummonerId);
                Console.WriteLine(dto.ToString());
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine($"stats not found : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("test exception", riotException);
                }
            }
        }
    }
}
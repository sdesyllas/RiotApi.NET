using System;
using NUnit.Framework;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Helpers;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class MatchListTests
    {
        [TestCase(41488614)]
        [TestCase(22293716)]
        public void GetMatchById(long summonerId)
        {
            try
            {
                var dto = GlobalSetup.RiotHttpClient.MatchList.GetMatchListBySummonerId(RiotApiConfig.Regions.EUNE, summonerId);
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
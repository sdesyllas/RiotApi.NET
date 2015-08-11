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
    public class MatchTests
    {
        [TestCase(1215776516)]
        [TestCase(1211206926)]
        public void GetMatchById(long matchId)
        {
            try
            {
                var dto = GlobalSetup.RiotHttpClient.Match.GetMatchById(RiotApiConfig.Regions.EUNE, matchId, includeTimeline: true);
                Assert.NotNull(dto);
                Assert.AreEqual(matchId, dto.MatchId);
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
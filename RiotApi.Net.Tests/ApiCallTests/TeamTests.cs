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
    public class TeamTests
    {
        [Test]
        public void GetSummonersByName()
        {
            var dto = GlobalSetup.RiotClient.Team.GetTeamsBySummonerId(RiotApiConfig.Regions.EUNE, "41488614", "41468510");
            Assert.NotNull(dto);
            foreach (var teams in dto.Values)
            {
                teams.ToList().ForEach(Console.WriteLine);
            }
        }

        [Test]
        public void GetTeamsByTeamId()
        {
            var dto = GlobalSetup.RiotClient.Team.GetTeamsByTeamId(RiotApiConfig.Regions.EUNE, "TEAM-18cc5c20-b4f9-11e4-80a9-782bcb46f3e4",
                "TEAM-b999b8d0-18d8-11e5-8e2b-782bcb46f3e4", "TEAM-a42274a0-0868-11e4-8646-782bcb4d190f");
            Assert.NotNull(dto);
            dto.Values.ToList().ForEach(Console.WriteLine);
        }
    }
}
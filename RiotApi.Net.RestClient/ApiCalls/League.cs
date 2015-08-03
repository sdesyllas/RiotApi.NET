using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.League;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class League: GenericRiotCaller, ILeague
    {
        public League(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        public Dictionary<string, IEnumerable<LeagueDto>> GetSummonerLeaguesByIds(RiotApiConfig.Regions region, params long[] summonerIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/by-summoner/22293716,41488614?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/eune/v2.5/league/by-summoner/{string.Join(",", summonerIds)}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, IEnumerable<LeagueDto>>>(baseUrl, apiCallPath);
            return dto;
        }

        public Dictionary<string, IEnumerable<LeagueDto>> GetSummonerLeagueEntriesByIds(RiotApiConfig.Regions region, params long[] summonerIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/by-summoner/22293716,41488614/entry?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/eune/v2.5/league/by-summoner/{string.Join(",", summonerIds)}/entry?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, IEnumerable<LeagueDto>>>(baseUrl, apiCallPath);
            return dto;
        }

        public Dictionary<string, IEnumerable<LeagueDto>> GetTeamLeaguesbyIds(RiotApiConfig.Regions region, params string[] teamIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/by-team/TEAM-18cc5c20-b4f9-11e4-80a9-782bcb46f3e4,TEAM-b999b8d0-18d8-11e5-8e2b-782bcb46f3e4?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/eune/v2.5/league/by-team/{string.Join(",", teamIds)}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, IEnumerable<LeagueDto>>>(baseUrl, apiCallPath);
            return dto;
        }

        public Dictionary<string, IEnumerable<LeagueDto>> GetTeamLeagueEntriesbyIds(RiotApiConfig.Regions region, params string[] teamIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/by-team/TEAM-18cc5c20-b4f9-11e4-80a9-782bcb46f3e4,TEAM-b999b8d0-18d8-11e5-8e2b-782bcb46f3e4/entry?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/eune/v2.5/league/by-team/{string.Join(",", teamIds)}/entry?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, IEnumerable<LeagueDto>>>(baseUrl, apiCallPath);
            return dto;
        }

        public LeagueDto GetChallengerTierLeagues(RiotApiConfig.Regions region, Enums.GameQueueType type)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/challenger?type=RANKED_SOLO_5x5&api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/eune/v2.5/league/challenger?type={type}&api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<LeagueDto>(baseUrl, apiCallPath);
            return dto;
        }

        public LeagueDto GetMasterTierLeagues(RiotApiConfig.Regions region, Enums.GameQueueType type)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/master?type=RANKED_TEAM_5x5&api_key= 
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/eune/v2.5/league/master?type={type}&api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<LeagueDto>(baseUrl, apiCallPath);
            return dto;
        }
    }
}

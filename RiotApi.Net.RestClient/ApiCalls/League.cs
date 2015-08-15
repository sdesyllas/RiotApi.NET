using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.League;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    /// league-v2.5 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public class League: GenericRiotCaller, ILeague
    {
        public League(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Get leagues mapped by summoner ID for a given list of summoner IDs.
        /// Implementation Notes :
        /// Returns all leagues for specified summoners and summoners' teams. Entries for each requested participant 
        /// (i.e., each summoner and related teams) will be included in the returned leagues data, 
        /// whether or not the participant is inactive. However, no entries for other inactive summoners or teams in the leagues will be included.
        /// </summary>
        /// <param name="region">The region of the leagues.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs. Maximum allowed at once is 10.</param>
        /// <returns>Map[string, List[LeagueDto]] LeagueDto - This object contains league information.</returns>
        public Dictionary<string, IEnumerable<LeagueDto>> GetSummonerLeaguesByIds(RiotApiConfig.Regions region, params long[] summonerIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/by-summoner/22293716,41488614?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.5/league/by-summoner/{string.Join(",", summonerIds)}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, IEnumerable<LeagueDto>>>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get league entries mapped by summoner ID for a given list of summoner IDs.
        /// Implementation Notes :
        /// Returns all league entries for specified summoners and summoners' teams.
        /// </summary>
        /// <param name="region">The region of the leagues.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs. Maximum allowed at once is 10.</param>
        /// <returns>Map[string, List[LeagueDto]] LeagueDto - This object contains league information.</returns>
        public Dictionary<string, IEnumerable<LeagueDto>> GetSummonerLeagueEntriesByIds(RiotApiConfig.Regions region, params long[] summonerIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/by-summoner/22293716,41488614/entry?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.5/league/by-summoner/{string.Join(",", summonerIds)}/entry?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, IEnumerable<LeagueDto>>>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get leagues mapped by team ID for a given list of team IDs.
        /// Implementation Notes :
        /// Returns all leagues for specified teams.Entries for each requested team will be included in the returned leagues data, 
        /// whether or not the team is inactive.However, no entries for other inactive teams in the leagues will be included.
        /// </summary>
        /// <param name="region">The region of the leagues.</param>
        /// <param name="teamIds">Comma-separated list of team IDs. Maximum allowed at once is 10.</param>
        /// <returns>Map[string, List[LeagueDto]] LeagueDto - This object contains league information.</returns>
        public Dictionary<string, IEnumerable<LeagueDto>> GetTeamLeaguesbyIds(RiotApiConfig.Regions region, params string[] teamIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/by-team/TEAM-18cc5c20-b4f9-11e4-80a9-782bcb46f3e4,TEAM-b999b8d0-18d8-11e5-8e2b-782bcb46f3e4?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.5/league/by-team/{string.Join(",", teamIds)}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, IEnumerable<LeagueDto>>>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get league entries mapped by team ID for a given list of team IDs.
        /// Implementation Notes
        /// Returns all league entries for specified teams.
        /// </summary>
        /// <param name="region">The region of the leagues.</param>
        /// <param name="teamIds">Comma-separated list of team IDs. Maximum allowed at once is 10.</param>
        /// <returns>Map[string, List[LeagueDto]] LeagueDto - This object contains league information.</returns>
        public Dictionary<string, IEnumerable<LeagueDto>> GetTeamLeagueEntriesbyIds(RiotApiConfig.Regions region, params string[] teamIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/by-team/TEAM-18cc5c20-b4f9-11e4-80a9-782bcb46f3e4,TEAM-b999b8d0-18d8-11e5-8e2b-782bcb46f3e4/entry?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.5/league/by-team/{string.Join(",", teamIds)}/entry?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, IEnumerable<LeagueDto>>>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get challenger tier leagues.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="type">Game queue type.</param>
        /// <returns>LeagueDto - This object contains league information.</returns>
        public LeagueDto GetChallengerTierLeagues(RiotApiConfig.Regions region, Enums.GameQueueType type)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/challenger?type=RANKED_SOLO_5x5&api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.5/league/challenger?type={type}&api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<LeagueDto>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get master tier leagues.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="type">Game queue type.</param>
        /// <returns>LeagueDto - This object contains league information.</returns>
        public LeagueDto GetMasterTierLeagues(RiotApiConfig.Regions region, Enums.GameQueueType type)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.5/league/master?type=RANKED_TEAM_5x5&api_key= 
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.5/league/master?type={type}&api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<LeagueDto>(baseUrl, apiCallPath);
            return dto;
        }
    }
}

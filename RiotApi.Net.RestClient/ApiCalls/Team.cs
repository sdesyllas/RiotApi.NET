using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Team;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    /// team-v2.4 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public class Team : GenericRiotCaller, ITeam
    {
        public Team(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Get teams mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="region">The region of the summoner.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs. Maximum allowed at once is 10.</param>
        /// <returns>Return Value: Map[string, List[TeamDto]] TeamDto - This object contains team information.</returns>
        public Dictionary<string, IEnumerable<TeamDto>> GetTeamsBySummonerId(RiotApiConfig.Regions region, params string[] summonerIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.4/team/by-summoner/41488614,41468510?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.4/team/by-summoner/{string.Join(",", summonerIds)}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, IEnumerable<TeamDto>>>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get teams mapped by team ID for a given list of team IDs.
        /// </summary>
        /// <param name="region">The region of the summoner.</param>
        /// <param name="teamIds">Comma-separated list of team IDs. Maximum allowed at once is 10.</param>
        /// <returns>Return Value: Map[string, TeamDto] TeamDto - This object contains team information.</returns>
        public Dictionary<string, TeamDto> GetTeamsByTeamId(RiotApiConfig.Regions region, params string[] teamIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.4/team/TEAM-18cc5c20-b4f9-11e4-80a9-782bcb46f3e4?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.4/team/{string.Join(",", teamIds)}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, TeamDto>>(baseUrl, apiCallPath);
            return dto;
        }
    }
}
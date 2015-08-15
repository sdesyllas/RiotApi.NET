using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Stats;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    ///  stats-v1.3 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public class Stats: GenericRiotCaller, IStats
    {
        public Stats(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Get ranked stats by summoner ID.
        /// Implementation Notes
        /// Includes ranked stats for Twisted Treeline and Summoner's Rift.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve ranked stats.</param>
        /// <param name="season">If specified, stats for the given season are returned. Otherwise, stats for the current season are returned.</param>
        /// <returns>RankedStatsDto - This object contains ranked stats information.</returns>
        public RankedStatsDto GetRankedStatsBySummonerId(RiotApiConfig.Regions region, long summonerId, string season = null)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.3/stats/by-summoner/22293716/ranked?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v1.3/stats/by-summoner/{summonerId}/ranked?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(season))
            {
                apiCallPath += $"&season={season}";
            }
            //make the call
            var dto = MakeCallToRiotApi<RankedStatsDto>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get player stats summaries by summoner ID.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="season">If specified, stats for the given season are returned. Otherwise, stats for the current season are returned.</param>
        /// <returns>PlayerStatsSummaryListDto - This object contains a collection of player stats summary information.</returns>
        public PlayerStatsSummaryListDto GetPlayerStatsBySummonerId(RiotApiConfig.Regions region, long summonerId, string season = null)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.3/stats/by-summoner/22293716/summary?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v1.3/stats/by-summoner/{summonerId}/summary?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(season))
            {
                apiCallPath += $"&season={season}";
            }
            //make the call
            var dto = MakeCallToRiotApi<PlayerStatsSummaryListDto>(baseUrl, apiCallPath);
            return dto;
        }
    }
}
using System;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Match.MatchHistory;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    ///  matchhistory-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public class MatchHistory : GenericRiotCaller, IMatchHistory
    {
        public MatchHistory(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Retrieve match history by summoner ID.
        /// Implementation Notes
        /// The maximum range for begin and end index is 15. If the range is more than 15, 
        /// the end index will be modified to enforce the 15 game limit.If only one of the index parameters is specified, 
        /// the other will be computed accordingly.
        /// </summary>
        /// <param name="region">The region of the summoner.</param>
        /// <param name="summonerId">The ID of the summoner.</param>
        /// <param name="championIds">Comma-separated list of champion IDs to use for fetching games.</param>
        /// <param name="rankedQueues">Comma-separated list of ranked queue types to use for fetching games. Non-ranked queue types will be ignored.</param>
        /// <param name="beginIndex">The begin index to use for fetching games.</param>
        /// <param name="endIndex">The end index to use for fetching games.</param>
        /// <returns>PlayerHistory - This object contains player match history information</returns>
        public PlayerHistory GetMatchHistoryBySummonerId(RiotApiConfig.Regions region, long summonerId, string championIds = null, string rankedQueues = null, int? beginIndex = default(int?), int? endIndex = default(int?))
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.2/matchhistory/22293716?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.2/matchhistory/{summonerId}?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(championIds))
            {
                apiCallPath += $"&championIds={championIds}";
            }
            if (!string.IsNullOrEmpty(rankedQueues))
            {
                apiCallPath += $"&rankedQueues={rankedQueues}";
            }
            if (beginIndex.HasValue)
            {
                apiCallPath += $"&beginIndex={beginIndex}";
            }
            if (endIndex.HasValue)
            {
                apiCallPath += $"&endIndex={endIndex}";
            }
            //make the call
            var dto = MakeCallToRiotApi<PlayerHistory>(baseUrl, apiCallPath);
            return dto;
        }
    }
}
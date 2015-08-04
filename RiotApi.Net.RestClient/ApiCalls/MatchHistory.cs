using System;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Match.MatchHistory;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class MatchHistory : GenericRiotCaller, IMatchHistory
    {
        public MatchHistory(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

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
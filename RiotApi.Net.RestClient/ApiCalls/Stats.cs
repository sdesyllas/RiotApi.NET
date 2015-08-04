using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Stats;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class Stats: GenericRiotCaller, IStats
    {
        public Stats(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

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
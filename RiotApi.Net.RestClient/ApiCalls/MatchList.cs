using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Match;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class MatchList: GenericRiotCaller, IMatchList
    {
        public MatchList(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        public MatchListDto GetMatchListBySummonerId(RiotApiConfig.Regions region, long summonerId, string championIds = null,
            string rankedQueues = null, string seasons = null, long? beginTime = null, long? endTime = null,
            int? beginIndex = null, int? endIndex = null)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.2/matchlist/by-summoner/22293716?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.2/matchlist/by-summoner/{summonerId}?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(championIds))
            {
                apiCallPath += $"&championIds={championIds}";
            }
            if (!string.IsNullOrEmpty(rankedQueues))
            {
                apiCallPath += $"&rankedQueues={rankedQueues}";
            }
            if (!string.IsNullOrEmpty(seasons))
            {
                apiCallPath += $"&seasons={seasons}";
            }
            if (beginTime.HasValue)
            {
                apiCallPath += $"&beginTime={beginTime}";
            }
            if (endTime.HasValue)
            {
                apiCallPath += $"&endTime={endTime}";
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
            var dto = MakeCallToRiotApi<MatchListDto>(baseUrl, apiCallPath);
            return dto;
        }
    }
}
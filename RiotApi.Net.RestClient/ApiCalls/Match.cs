using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Match;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class Match: GenericRiotCaller, IMatch
    {
        public Match(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        public MatchDetail GetMatchById(RiotApiConfig.Regions region, long matchId, bool? includeTimeline = null)
        {
            //https://eune.api.pvp.net/api/lol/eune/v2.2/match/1?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v2.2/match/{matchId}?api_key={this.ApiKey}";
            //add additional parameters
            if (includeTimeline.HasValue)
            {
                apiCallPath += $"&includeTimeline={includeTimeline}";
            }
            //make the call
            var dto = MakeCallToRiotApi<MatchDetail>(baseUrl, apiCallPath);
            return dto;
        }
    }
}
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Match;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    /// match-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public class Match: GenericRiotCaller, IMatch
    {
        public Match(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Retrieve match by match ID.
        /// Implementation Notes
        /// Not all matches have timeline data.If timeline data is requested, but doesn't exist, then the response won't include it.
        /// </summary>
        /// <param name="region">The region of the summoner.</param>
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="includeTimeline">Flag indicating whether or not to include match timeline data</param>
        /// <returns>MatchDetail - This object contains match detail information</returns>
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
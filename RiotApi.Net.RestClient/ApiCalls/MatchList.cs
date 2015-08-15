using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Match;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    /// matchlist-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
    /// </summary>
    public class MatchList: GenericRiotCaller, IMatchList
    {
        public MatchList(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Retrieve match list by summoner ID
        /// Implementation Notes
        /// A number of optional parameters are provided for filtering.It is up to the caller to ensure that the combination 
        /// of filter parameters provided is valid for the requested summoner, otherwise, no matches may be returned.
        /// The maximum range for begin and end index is 20. If the range is more than 20, the end index will be modified to enforce 
        /// the 20 game limit.If only one of the index parameters is specified, the other will be computed accordingly using the maximum range.
        /// If the beginTimestamp parameter is specified on its own, endTimestamp is assumed to be the current time. 
        /// If the endTimestamp parameter is specified on its own, beginTimestamp is assumed to be the start of the summoner's match history. 
        /// There is no limit on the allowed timestamp range.
        /// </summary>
        /// <param name="region">The region of the summoner.</param>
        /// <param name="summonerId">The ID of the summoner.</param>
        /// <param name="championIds">Comma-separated list of champion IDs to use for fetching games.</param>
        /// <param name="rankedQueues">Comma-separated list of ranked queue types to use for fetching games. Non-ranked queue types will be ignored.</param>
        /// <param name="seasons">Comma-separated list of seasons to use for fetching games.</param>
        /// <param name="beginTime">The begin time to use for fetching games specified as epoch milliseconds.</param>
        /// <param name="endTime">The end time to use for fetching games specified as epoch milliseconds.</param>
        /// <param name="beginIndex">The begin index to use for fetching games.</param>
        /// <param name="endIndex">The end index to use for fetching games.</param>
        /// <returns>MatchList - This object contains match list information</returns>
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
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Match;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// matchlist-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
    /// </summary>
    public interface IMatchList
    {
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
        /// <returns>Return Value: MatchList</returns>
        MatchListDto GetMatchListBySummonerId(RiotApiConfig.Regions region, long summonerId,
            string championIds = null, string rankedQueues = null, string seasons = null, long? beginTime = null,
            long? endTime = null,
            int? beginIndex = null, int? endIndex = null);
    }
}
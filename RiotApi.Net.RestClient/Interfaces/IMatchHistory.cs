using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Match.MatchHistory;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    ///  matchhistory-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public interface IMatchHistory
    {
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
        /// <returns></returns>
        PlayerHistory GetMatchHistoryBySummonerId(RiotApiConfig.Regions region, long summonerId,
            string championIds = "", string rankedQueues = "", int beginIndex = 0, int endIndex = 15);
    }
}

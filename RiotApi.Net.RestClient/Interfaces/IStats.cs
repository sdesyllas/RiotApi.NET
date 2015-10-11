using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Stats;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// stats-v1.3 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public interface IStats
    {
        /// <summary>
        /// Get ranked stats by summoner ID.
        /// Implementation Notes
        /// Includes ranked stats for Twisted Treeline and Summoner's Rift.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve ranked stats.</param>
        /// <param name="season">If specified, stats for the given season are returned. Otherwise, stats for the current season are returned.</param>
        /// <returns>RankedStatsDto - This object contains ranked stats information.</returns>
        RankedStatsDto GetRankedStatsBySummonerId(RiotApiConfig.Regions region, long summonerId, string season = null);

        /// <summary>
        /// Get player stats summaries by summoner ID.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="season">If specified, stats for the given season are returned. Otherwise, stats for the current season are returned.</param>
        /// <returns>PlayerStatsSummaryListDto - This object contains a collection of player stats summary information.</returns>
        PlayerStatsSummaryListDto GetPlayerStatsBySummonerId(RiotApiConfig.Regions region, long summonerId,
            string season = null);
    }
}

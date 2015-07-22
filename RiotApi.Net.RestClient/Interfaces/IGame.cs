using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Game;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// game-v1.3 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Get recent games by summoner ID.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve recent games.</param>
        /// <returns>RecentGamesDto - This object contains recent games information.</returns>
        RecentGamesDto GetRecentGamesBySummonerId(RiotApiConfig.Regions region, long summonerId);
    }
}

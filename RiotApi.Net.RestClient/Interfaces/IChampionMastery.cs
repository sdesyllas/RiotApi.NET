using System.Collections.Generic;
using RiotApi.Net.RestClient.Dto.ChampionMastery;
using RiotApi.Net.RestClient.Configuration;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// championmastery [BR, EUNE, EUW, JP, KR, LAN, LAS, NA, OCE, RU, TR]
    /// </summary>
    public interface IChampionMastery
    {
        /// <summary>
        /// Get a champion mastery by player id and champion id
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="playerID">Summoner ID associated with the player.</param>
        /// <param name="championId">Champion ID to retrieve Champion Mastery for</param>
        /// <returns>ChampionMasteryDTO - This object contains single Champion Mastery information for player and champion combination.</returns>
        ChampionMasteryDto RetrieveChampionMasteryByID(RiotApiConfig.Regions region, long playerID, long championId);

        /// <summary>
        /// Get all champion mastery entries sorted by number of champion points descending (RPC)
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="playerID">Summoner ID associated with the player.</param>
        /// <returns>Collection of ChampionMasteryDTOs - This object contains single Champion Mastery information for player and champion combination.</returns>
        IEnumerable<ChampionMasteryDto> RetrieveChampionMasteriesByPlayerId(RiotApiConfig.Regions region, long playerID);

        /// <summary>
        /// Get a player's total champion mastery score, which is sum of individual champion mastery levels (RPC)
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="playerID">Summoner ID associated with the player.</param>
        /// <returns>int</returns>
        int RetrieveChampionMasterScore(RiotApiConfig.Regions region, long playerID);

        /// <summary>
        /// Get specified number of top champion mastery entries sorted by number of champion points descending (RPC)
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="playerID">Summoner ID associated with the player.</param>
        /// <returns>Collection of ChampionMasteryDTOs - This object contains single Champion Mastery information for player and champion combination.</returns>
        IEnumerable<ChampionMasteryDto> RetrieveTopChampions(RiotApiConfig.Regions region, long playerID, int? count);
    }
}

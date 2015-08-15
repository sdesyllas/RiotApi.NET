using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.CurrentGame;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// current-game-v1.0 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR] 
    /// </summary>
    public interface ICurrentGame
    {
        /// <summary>
        /// Get current game information for the given summoner ID.
        /// </summary>
        /// <param name="platformId">The platform ID for which to fetch data.</param>
        /// <param name="summonerId">The ID of the summoner.</param>
        /// <returns>CurrentGameInfo</returns>
        CurrentGameInfo GetCurrentGameInformationForSummonerId(RiotApiConfig.Platforms platformId, long summonerId);
    }
}

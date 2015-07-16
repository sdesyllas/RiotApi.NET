using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.FeaturedGames;
using RiotApi.Net.RestClient.Helpers;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// featured-games-v1.0 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR] 
    /// </summary>
    public interface IFeaturedGames
    {
        /// <summary>
        /// Get list of featured games
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>FeaturedGames</returns>
        FeaturedGames GetListOfFeaturedGames(RiotApiConfig.Regions region);
    }
}

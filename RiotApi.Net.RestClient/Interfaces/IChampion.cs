using System.Security.Cryptography.X509Certificates;
using RiotApi.Net.RestClient.Dto.Champion;
using RiotApi.Net.RestClient.Configuration;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// champion-v1.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
    /// </summary>
    public interface IChampion
    {
        /// <summary>
        /// Riot Api Key
        /// </summary>
        string ApiKey { get; set; }

        /// <summary>
        /// Retrieve all champions. (REST)
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="freeToPlay">Optional filter param to retrieve only free to play champions.</param>
        /// <returns>ChampionListDto - This object contains a collection of champion information.</returns>
        ChampionListDto RetrieveAllChampions(RiotApiConfig.Regions region, bool? freeToPlay = null);

        /// <summary>
        /// Retrieve champion by ID.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="id"></param>
        /// <returns>ChampionDto - This object contains champion information.</returns>
        ChampionListDto.ChampionDto RetrieveChampionById(RiotApiConfig.Regions region, int id);
    }
}

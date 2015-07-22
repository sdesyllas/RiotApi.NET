using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Summoner;
using RiotApi.Net.RestClient.Dto.Summoner.Masteries;
using RiotApi.Net.RestClient.Dto.Summoner.Runes;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    ///  summoner-v1.4 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public interface ISummoner
    {
        /// <summary>
        /// Get summoner objects mapped by standardized summoner name for a given list of summoner names.
        /// Implementation Notes
        /// The response object contains the summoner objects mapped by the standardized summoner name, 
        /// which is the summoner name in all lower case and with spaces removed.
        /// Use this version of the name when checking if the returned object contains the data for a given summoner.
        /// This API will also accept standardized summoner names as valid parameters, although they are not required.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerNames">Comma-separated list of summoner names or standardized summoner names associated with summoners to retrieve. Maximum allowed at once is 40.</param>
        /// <returns> Map[string, SummonerDto] SummonerDto - This object contains summoner information.</returns>
        Dictionary<string, SummonerDto> GetSummonersByName(RiotApiConfig.Regions region, params string[] summonerNames);

        /// <summary>
        /// Get summoner objects mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with summoners to retrieve. Maximum allowed at once is 40.</param>
        /// <returns>Return Value: Map[string, SummonerDto] SummonerDto - This object contains summoner information.</returns>
        Dictionary<string, SummonerDto> GetSummonersById(RiotApiConfig.Regions region, params string[] summonerIds);

        /// <summary>
        /// Get mastery pages mapped by summoner ID for a given list of summoner IDs
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with masteries to retrieve. Maximum allowed at once is 40.</param>
        /// <returns></returns>
        Dictionary<string, MasteryPagesDto> GetMasteryPagesBySummonerId(RiotApiConfig.Regions region, params string[] summonerIds);

        /// <summary>
        /// Get summoner names mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with summoner names to retrieve. Maximum allowed at once is 40.</param>
        /// <returns>Return Value: Map[string, string]</returns>
        Dictionary<string, string> GetSummonerNamesBySummonerId(RiotApiConfig.Regions region, params string[] summonerIds);

        /// <summary>
        /// Get rune pages mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with runes to retrieve. Maximum allowed at once is 40.</param>
        /// <returns>Return Value: Map[string, RunePagesDto] RunePagesDto - This object contains rune pages information.</returns>
        Dictionary<string, RunePagesDto> GetRunePagesBySummonerId(RiotApiConfig.Regions region, params string[] summonerIds);
    }
}

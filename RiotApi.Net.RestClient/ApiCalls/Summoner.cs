using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Summoner;
using RiotApi.Net.RestClient.Dto.Summoner.Masteries;
using RiotApi.Net.RestClient.Dto.Summoner.Runes;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    ///  summoner-v1.4 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public class Summoner : GenericRiotCaller, ISummoner
    {
        public Summoner(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

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
        public Dictionary<string, SummonerDto> GetSummonersByName(RiotApiConfig.Regions region, params string[] summonerNames)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.4/summoner/by-name/xeyanord,onesa?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v1.4/summoner/by-name/{string.Join(",",summonerNames)}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, SummonerDto>>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get summoner objects mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with summoners to retrieve. Maximum allowed at once is 40.</param>
        /// <returns>Return Value: Map[string, SummonerDto] SummonerDto - This object contains summoner information.</returns>
        public Dictionary<string, SummonerDto> GetSummonersById(RiotApiConfig.Regions region, params string[] summonerIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.4/summoner/41468510,41488614?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v1.4/summoner/{string.Join(",", summonerIds)}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, SummonerDto>>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get mastery pages mapped by summoner ID for a given list of summoner IDs
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with masteries to retrieve. Maximum allowed at once is 40.</param>
        /// <returns></returns>
        public Dictionary<string, MasteryPagesDto> GetMasteryPagesBySummonerId(RiotApiConfig.Regions region, params string[] summonerIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.4/summoner/41488614,41468510/masteries?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v1.4/summoner/{string.Join(",", summonerIds)}/masteries?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, MasteryPagesDto>>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get summoner names mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with summoner names to retrieve. Maximum allowed at once is 40.</param>
        /// <returns>Return Value: Map[string, string]</returns>
        public Dictionary<string, string> GetSummonerNamesBySummonerId(RiotApiConfig.Regions region, params string[] summonerIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.4/summoner/41488614,41468510/name?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v1.4/summoner/{string.Join(",", summonerIds)}/name?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, string>>(baseUrl, apiCallPath);
            return dto;
        }

        /// <summary>
        /// Get rune pages mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with runes to retrieve. Maximum allowed at once is 40.</param>
        /// <returns>Return Value: Map[string, RunePagesDto] RunePagesDto - This object contains rune pages information.</returns>
        public Dictionary<string, RunePagesDto> GetRunePagesBySummonerId(RiotApiConfig.Regions region, params string[] summonerIds)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.4/summoner/41488614,41468510/runes?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v1.4/summoner/{string.Join(",", summonerIds)}/runes?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dictionary<string, RunePagesDto>>(baseUrl, apiCallPath);
            return dto;
        }
    }
}

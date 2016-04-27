using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.ChampionMastery;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
   

    public class ChampionMastery : GenericRiotCaller, IChampionMastery
    {
        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        public ChampionMastery(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Get a champion mastery by player id and champion id
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="playerID">Summoner ID associated with the player.</param>
        /// <param name="championId">Champion ID to retrieve Champion Mastery for</param>
        /// <returns>ChampionMasteryDTO - This object contains single Champion Mastery information for player and champion combination.</returns>
        public ChampionMasteryDto RetrieveChampionMasteryByID(RiotApiConfig.Regions region, long playerID, long championId)
        {
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"championmastery/location/{endPoint.PlatformId.ToLower()}/player/{playerID}/champion/{championId}?api_key={this.ApiKey}";
            return MakeCallToRiotApi<ChampionMasteryDto>(baseUrl, apiCallPath);
        }

        /// <summary>
        /// Get all champion mastery entries sorted by number of champion points descending (RPC)
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="playerID">Summoner ID associated with the player.</param>
        /// <returns>Collection of ChampionMasteryDTOs - This object contains single Champion Mastery information for player and champion combination.</returns>
        public IEnumerable<ChampionMasteryDto> RetrieveChampionMasteriesByPlayerId(RiotApiConfig.Regions region, long playerID)
        {
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"championmastery/location/{endPoint.PlatformId.ToLower()}/player/{playerID}/champions?api_key={this.ApiKey}";
            return MakeCallToRiotApi<IEnumerable<ChampionMasteryDto>>(baseUrl, apiCallPath);
        }

        /// <summary>
        /// Get a player's total champion mastery score, which is sum of individual champion mastery levels (RPC)
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="playerID">Summoner ID associated with the player.</param>
        /// <returns>int</returns>
        public int RetrieveChampionMasterScore(RiotApiConfig.Regions region, long playerID)
        {
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"championmastery/location/{endPoint.PlatformId.ToLower()}/player/{playerID}/score?api_key={this.ApiKey}";
            return MakeCallToRiotApi<int>(baseUrl, apiCallPath);
        }


        /// <summary>
        /// Get specified number of top champion mastery entries sorted by number of champion points descending (RPC)
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="playerID">Summoner ID associated with the player.</param>
        /// <returns>Collection of ChampionMasteryDTOs - This object contains single Champion Mastery information for player and champion combination.</returns>
        public IEnumerable<ChampionMasteryDto> RetrieveTopChampions(RiotApiConfig.Regions region, long playerID, int? count)
        {
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"championmastery/location/{endPoint.PlatformId.ToLower()}/player/{playerID}/topchampions?api_key={this.ApiKey}";

            if(count.HasValue)
            {
                apiCallPath += $"&count={count}";
            }

            return MakeCallToRiotApi<IEnumerable<ChampionMasteryDto>>(baseUrl, apiCallPath);
        }
    }
}

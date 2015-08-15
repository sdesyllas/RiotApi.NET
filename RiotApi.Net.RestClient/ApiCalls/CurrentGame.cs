using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.CurrentGame;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    /// current-game-v1.0 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR] 
    /// </summary>
    public class CurrentGame : GenericRiotCaller, ICurrentGame
    {
        public CurrentGame(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Get current game information for the given summoner ID.
        /// </summary>
        /// <param name="platformId">The platform ID for which to fetch data.</param>
        /// <param name="summonerId">The ID of the summoner.</param>
        /// <returns>CurrentGameInfo</returns>
        public CurrentGameInfo GetCurrentGameInformationForSummonerId(RiotApiConfig.Platforms platformId, long summonerId)
        {
            //https://eune.api.pvp.net/observer-mode/rest/consumer/getSpectatorGameInfo/EUN1/41488614?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByPlatform(platformId);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"observer-mode/rest/consumer/getSpectatorGameInfo/{platformId}/{summonerId}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<CurrentGameInfo>(baseUrl, apiCallPath);
            return dto;
        }
    }
}

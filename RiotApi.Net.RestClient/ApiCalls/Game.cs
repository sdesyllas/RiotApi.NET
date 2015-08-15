using RiotApi.Net.RestClient.Interfaces;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Game;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    /// game-v1.3 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public class Game : GenericRiotCaller, IGame
    {
        public Game(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Get recent games by summoner ID.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve recent games.</param>
        /// <returns>RecentGamesDto - This object contains recent games information.</returns>
        public RecentGamesDto GetRecentGamesBySummonerId(RiotApiConfig.Regions region, long summonerId)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.3/game/by-summoner/41488614/recent?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{region.ToString().ToLower()}/v1.3/game/by-summoner/{summonerId}/recent?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<RecentGamesDto>(baseUrl, apiCallPath);
            return dto;
        }
    }
}

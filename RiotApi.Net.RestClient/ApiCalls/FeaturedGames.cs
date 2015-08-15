using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    /// featured-games-v1.0 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR] 
    /// </summary>
    public class FeaturedGames : GenericRiotCaller, IFeaturedGames
    {
        public FeaturedGames(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Get list of featured games
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>FeaturedGames</returns>
        public Dto.FeaturedGames.FeaturedGames GetListOfFeaturedGames(RiotApiConfig.Regions region)
        {
            //https://eune.api.pvp.net/observer-mode/rest/featured?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"observer-mode/rest/featured?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<Dto.FeaturedGames.FeaturedGames>(baseUrl, apiCallPath);
            return dto;
        }
    }
}

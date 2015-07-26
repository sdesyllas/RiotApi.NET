using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class FeaturedGames : GenericRiotCaller, IFeaturedGames
    {
        public FeaturedGames(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

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

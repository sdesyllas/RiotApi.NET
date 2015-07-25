using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Champion;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class Champion : GenericRiotCaller, IChampion
    {
        public Champion(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        public ChampionListDto RetrieveAllChampions(RiotApiConfig.Regions region, bool? freeToPlay = null)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.2/champion?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{endPoint.Region.ToLower()}/v1.2/champion?api_key={this.ApiKey}";
            //add additional parameters
            if (freeToPlay.HasValue)
            {
                apiCallPath += $"&freeToPlay={freeToPlay}";
            }
            //make the call
            var dto = MakeCallToRiotApi<ChampionListDto>(baseUrl, apiCallPath);
            return dto;
        }

        public ChampionListDto.ChampionDto RetrieveChampionById(RiotApiConfig.Regions region, int id)
        {
            //https://eune.api.pvp.net/api/lol/eune/v1.2/champion/1?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(region);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/{endPoint.Region.ToLower()}/v1.2/champion/{id}?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<ChampionListDto.ChampionDto>(baseUrl, apiCallPath);
            return dto;
        }
    }
}

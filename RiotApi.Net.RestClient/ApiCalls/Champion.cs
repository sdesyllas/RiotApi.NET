using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Champion;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    /// champion-v1.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
    /// </summary>
    public class Champion : GenericRiotCaller, IChampion
    {
        public Champion(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Retrieve all champions. (REST)
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="freeToPlay">Optional filter param to retrieve only free to play champions.</param>
        /// <returns>ChampionListDto - This object contains a collection of champion information.</returns>
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

        /// <summary>
        /// Retrieve champion by ID.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="id">ID of the champion to retrieve.</param>
        /// <returns>ChampionDto - This object contains champion information.</returns>
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

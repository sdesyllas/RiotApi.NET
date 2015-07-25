using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.CurrentGame;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class CurrentGame : GenericRiotCaller, ICurrentGame
    {
        public CurrentGame(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        public CurrentGameInfo GetCurrentGameInformationForSummonerId(RiotApiConfig.Platforms platformId, long summonerId)
        {
            https://eune.api.pvp.net/observer-mode/rest/consumer/getSpectatorGameInfo/EUN1/41488614?api_key=
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

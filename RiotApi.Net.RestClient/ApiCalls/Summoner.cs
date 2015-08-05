using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Summoner;
using RiotApi.Net.RestClient.Dto.Summoner.Masteries;
using RiotApi.Net.RestClient.Dto.Summoner.Runes;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class Summoner : GenericRiotCaller, ISummoner
    {
        public Summoner(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

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

using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.LolStatus;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class LolStatus: GenericRiotCaller, ILolStatus
    {
        public IEnumerable<ShardDto> GetShards()
        {
            //http://status.leagueoflegends.com/shards
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.StatusUrl;
            //compose url
            var baseUrl = $"http://{endPoint}/";
            var apiCallPath = "shards";
            //make the call
            var dto = MakeCallToRiotApi<IEnumerable<ShardDto>>(baseUrl, apiCallPath);
            return dto;
        }

        public ShardStatusDto GetShardStatusByRegion(RiotApiConfig.Regions region)
        {
            //http://status.leagueoflegends.com/shards/eune
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.StatusUrl;
            //compose url
            var baseUrl = $"http://{endPoint}/";
            var apiCallPath = $"shards/{region.ToString().ToLower()}";
            //make the call
            var dto = MakeCallToRiotApi<ShardStatusDto>(baseUrl, apiCallPath);
            return dto;
        }
    }
}
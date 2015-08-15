using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.LolStatus;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    /// <summary>
    ///  lol-status-v1.0 [BR, EUNE, EUW, LAN, LAS, NA, OCE, PBE, RU, TR] 
    /// </summary>
    public class LolStatus: GenericRiotCaller, ILolStatus
    {
        /// <summary>
        /// Get shard list.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <returns>Return Value: List[Shard]</returns>
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

        /// <summary>
        /// Get shard status.Returns the data available on the status.leagueoflegends.com website for the given region.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region">The region for which to fetch data.</param>
        /// <returns>Return Value: ShardStatus</returns>
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
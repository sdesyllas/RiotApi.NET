using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.LolStatus;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    ///  lol-status-v1.0 [BR, EUNE, EUW, LAN, LAS, NA, OCE, PBE, RU, TR] 
    /// </summary>
    public interface ILolStatus
    {
        /// <summary>
        /// Get shard list.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <returns>Return Value: List[Shard]</returns>
        IEnumerable<ShardDto> GetShards();

        /// <summary>
        /// Get shard status.Returns the data available on the status.leagueoflegends.com website for the given region.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region">The region for which to fetch data.</param>
        /// <returns>Return Value: ShardStatus</returns>
        ShardStatusDto GetShardStatusByRegion(RiotApiConfig.Regions region);
    }
}

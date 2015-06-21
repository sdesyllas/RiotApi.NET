using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStatus
{
    /// <summary>
    /// LOL Status for each shard
    /// </summary>
    public class ShardDto
    {
        /// <summary>
        /// hostname	string
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string HostName { get; set; }

        /// <summary>
        /// locales	List[string]
        /// </summary>
        [JsonProperty(PropertyName = "locales")]
        public IEnumerable<string> Locales { get; set; }

        /// <summary>
        /// name	string
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public IEnumerable<string> Name { get; set; }

        /// <summary>
        /// region_tag	string
        /// </summary>
        [JsonProperty(PropertyName = "region_tag")]
        public IEnumerable<string> RegionTag { get; set; }

        /// <summary>
        /// slug	string
        /// </summary>
        [JsonProperty(PropertyName = "slug")]
        public IEnumerable<string> Slug { get; set; }
    }
}

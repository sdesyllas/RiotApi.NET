using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStatus
{
    /// <summary>
    /// LOL Status for each shard
    /// </summary>
    [DataContract]
    public class ShardDto : RiotDto
    {
        /// <summary>
        /// hostname	string
        /// </summary>
        [DataMember(Name = "hostname")]
        public string HostName { get; set; }

        /// <summary>
        /// locales	List[string]
        /// </summary>
        [DataMember(Name = "locales")]
        public IEnumerable<string> Locales { get; set; }

        /// <summary>
        /// name	string
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// region_tag	string
        /// </summary>
        [DataMember(Name = "region_tag")]
        public string RegionTag { get; set; }

        /// <summary>
        /// slug	string
        /// </summary>
        [DataMember(Name = "slug")]
        public string Slug { get; set; }
    }
}

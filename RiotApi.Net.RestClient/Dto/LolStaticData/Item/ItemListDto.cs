using Newtonsoft.Json;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Item
{
    /// <summary>
    /// This object contains item list data.
    /// </summary>
    public class ItemListDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "basic")]
        public BasicDataDto Basic { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, ItemDto> Data { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IEnumerable<GroupDto> Groups { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "tree")]
        public IEnumerable<ItemTreeDto> Tree { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains champion recommended block data.
    /// </summary>
    public class BlockDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IEnumerable<BlockItemDto> Items { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "recMath")]
        public bool RecMath { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Item
{
    /// <summary>
    /// This object contains item tree data.
    /// </summary>
    public class ItemTreeDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "header")]
        public string Header { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IEnumerable<string> Tags { get; set; }
    }
}

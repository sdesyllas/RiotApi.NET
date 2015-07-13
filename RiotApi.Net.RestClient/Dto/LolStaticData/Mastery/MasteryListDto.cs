using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Mastery
{
    /// <summary>
    /// This object contains mastery list data.
    /// </summary>
    public class MasteryListDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, MasteryDto> Data { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "tree")]
        public MasteryTreeDto Tree { get; set; }

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

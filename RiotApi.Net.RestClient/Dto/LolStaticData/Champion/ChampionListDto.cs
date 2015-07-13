using Newtonsoft.Json;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Champion
{
    /// <summary>
    /// This object contains champion list data.
    /// </summary>
    public class ChampionListDto : RiotDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, ChampionDto> Data { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "keys")]
        public Dictionary<string, string> Keys { get; set; }

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

using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains champion recommended block item data.
    /// </summary>
    public class BlockItemDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
    }
}

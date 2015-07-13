using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    ///  This object contains champion passive data.
    /// </summary>
    public class PassiveDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }
    }
}

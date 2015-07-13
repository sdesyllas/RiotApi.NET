using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains spell vars data.
    /// </summary>
    public class SpellVarsDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "coeff")]
        public IEnumerable<bool> Coeff { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "dyn")]
        public string Dyn { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "ranksWith")]
        public string RanksWith { get; set; }
    }
}

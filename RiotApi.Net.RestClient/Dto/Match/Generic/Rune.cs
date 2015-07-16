using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains rune information
    /// </summary>
    public class Rune
    {
        /// <summary>
        /// Rune rank
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public long Rank { get; set; }

        /// <summary>
        /// Rune ID
        /// </summary>
        [JsonProperty(PropertyName = "runeId")]
        public long RuneId { get; set; }
    }
}

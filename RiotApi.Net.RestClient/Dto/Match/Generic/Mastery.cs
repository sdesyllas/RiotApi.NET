using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains mastery information
    /// </summary>
    public class Mastery
    {
        /// <summary>
        /// Mastery ID
        /// </summary>
        [JsonProperty(PropertyName = "masteryId")]
        public long MasteryId { get; set; }

        /// <summary>
        /// Mastery rank
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public long Rank { get; set; }
    }
}

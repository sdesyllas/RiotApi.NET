using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains timeline data
    /// </summary>
    public class ParticipantTimelineData
    {
        /// <summary>
        /// Value per minute from 10 min to 20 min
        /// </summary>
        [JsonProperty(PropertyName = "tenToTwenty")]
        public double TenToTwenty { get; set; }

        /// <summary>
        /// Value per minute from 30 min to the end of the game
        /// </summary>
        [JsonProperty(PropertyName = "thirtyToEnd")]
        public double ThirtyToEnd { get; set; }

        /// <summary>
        /// Value per minute from 20 min to 30 min
        /// </summary>
        [JsonProperty(PropertyName = "twentyToThirty")]
        public double TwentyToThirty { get; set; }

        /// <summary>
        /// Value per minute from the beginning of the game to 10 min
        /// </summary>
        [JsonProperty(PropertyName = "zeroToTen")]
        public double ZeroToTen { get; set; }
    }
}

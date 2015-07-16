using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains game frame information
    /// </summary>
    public class Frame
    {
        /// <summary>
        /// List of events for this frame.
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IEnumerable<Event> Events { get; set; }

        /// <summary>
        /// Map of each participant ID to the participant's information for the frame.
        /// </summary>
        [JsonProperty(PropertyName = "participantFrames")]
        public Dictionary<string, ParticipantFrame> ParticipantFrames { get; set; }

        /// <summary>
        /// Represents how many milliseconds into the game the frame occurred.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }
    }
}

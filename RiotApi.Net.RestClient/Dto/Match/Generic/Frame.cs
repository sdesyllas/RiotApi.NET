using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains game frame information
    /// </summary>
    [DataContract]
    public class Frame
    {
        /// <summary>
        /// List of events for this frame.
        /// </summary>
        [DataMember(Name = "events")]
        public IEnumerable<Event> Events { get; set; }

        /// <summary>
        /// Map of each participant ID to the participant's information for the frame.
        /// </summary>
        [DataMember(Name = "participantFrames")]
        public Dictionary<string, ParticipantFrame> ParticipantFrames { get; set; }

        /// <summary>
        /// Represents how many milliseconds into the game the frame occurred.
        /// </summary>
        [DataMember(Name = "timestamp")]
        public long Timestamp { get; set; }
    }
}

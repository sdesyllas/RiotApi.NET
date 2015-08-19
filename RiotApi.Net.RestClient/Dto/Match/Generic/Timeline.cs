using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains game timeline information
    /// </summary>
    [DataContract]
    public class Timeline
    {
        /// <summary>
        /// Time between each returned frame in milliseconds.
        /// </summary>
        [DataMember(Name = "frameInterval")]
        public long FrameInterval { get; set; }

        /// <summary>
        /// List of timeline frames for the game.
        /// </summary>
        [DataMember(Name = "frames")]
        public IEnumerable<Frame> Frames { get; set; }
    }
}

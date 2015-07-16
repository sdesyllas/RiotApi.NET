using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains game timeline information
    /// </summary>
    public class Timeline
    {
        /// <summary>
        /// Time between each returned frame in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "frameInterval")]
        public long FrameInterval { get; set; }

        /// <summary>
        /// List of timeline frames for the game.
        /// </summary>
        [JsonProperty(PropertyName = "frames")]
        public IEnumerable<Frame> Frames { get; set; }
    }
}

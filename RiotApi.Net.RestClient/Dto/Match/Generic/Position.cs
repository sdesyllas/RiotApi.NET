using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains participant frame position information
    /// </summary>
    public class Position
    {
        /// <summary>
        /// x
        /// </summary>
        [JsonProperty(PropertyName = "x")]
        public int X { get; set; }

        /// <summary>
        /// y
        /// </summary>
        [JsonProperty(PropertyName = "y")]
        public int Y { get; set; }
    }
}

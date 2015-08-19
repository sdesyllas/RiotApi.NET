using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains participant frame position information
    /// </summary>
    [DataContract]
    public class Position : RiotDto
    {
        /// <summary>
        /// x
        /// </summary>
        [DataMember(Name = "x")]
        public int X { get; set; }

        /// <summary>
        /// y
        /// </summary>
        [DataMember(Name = "y")]
        public int Y { get; set; }
    }
}

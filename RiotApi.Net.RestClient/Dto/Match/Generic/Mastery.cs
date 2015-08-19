using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains mastery information
    /// </summary>
    [DataContract]
    public class Mastery
    {
        /// <summary>
        /// Mastery ID
        /// </summary>
        [DataMember(Name = "masteryId")]
        public long MasteryId { get; set; }

        /// <summary>
        /// Mastery rank
        /// </summary>
        [DataMember(Name = "rank")]
        public long Rank { get; set; }
    }
}

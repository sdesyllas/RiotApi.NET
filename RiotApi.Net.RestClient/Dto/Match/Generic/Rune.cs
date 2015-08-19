using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains rune information
    /// </summary>
    [DataContract]
    public class Rune
    {
        /// <summary>
        /// Rune rank
        /// </summary>
        [DataMember(Name = "rank")]
        public long Rank { get; set; }

        /// <summary>
        /// Rune ID
        /// </summary>
        [DataMember(Name = "runeId")]
        public long RuneId { get; set; }
    }
}

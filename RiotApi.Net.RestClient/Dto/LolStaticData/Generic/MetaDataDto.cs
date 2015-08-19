using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains meta data.
    /// </summary>
    [DataContract]
    public class MetaDataDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "isRune")]
        public bool IsRune { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}

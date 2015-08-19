using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains champion level tip data.
    /// </summary>
    [DataContract]
    public class LevelTipDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "effect")]
        public IEnumerable<string> Effect { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "label")]
        public IEnumerable<string> Label { get; set; }
    }
}

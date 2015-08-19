using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains spell vars data.
    /// </summary>
    [DataContract]
    public class SpellVarsDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "coeff")]
        public IEnumerable<double> Coeff { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "dyn")]
        public string Dyn { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "key")]
        public string Key { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "link")]
        public string Link { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "ranksWith")]
        public string RanksWith { get; set; }
    }
}

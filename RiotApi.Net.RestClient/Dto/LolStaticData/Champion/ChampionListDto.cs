using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Champion
{
    /// <summary>
    /// This object contains champion list data.
    /// </summary>
    [DataContract]
    public class ChampionListDto : RiotDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "data")]
        public Dictionary<string, ChampionDto> Data { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "format")]
        public string Format { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "keys")]
        public Dictionary<string, string> Keys { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "version")]
        public string Version { get; set; }
    }
}

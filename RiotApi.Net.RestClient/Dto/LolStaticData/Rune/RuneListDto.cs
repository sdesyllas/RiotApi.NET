using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Rune
{
    /// <summary>
    /// Not all data specified below is returned by default. See the runeListData parameter for more information.
    /// </summary>
    [DataContract]
    public class RuneListDto : RiotDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "basic")]
        public BasicDataDto Basic { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "data")]
        public Dictionary<string, RuneDto> Data { get; set; }

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

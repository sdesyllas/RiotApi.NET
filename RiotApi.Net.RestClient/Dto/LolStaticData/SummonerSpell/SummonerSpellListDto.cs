using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.SummonerSpell
{
    /// <summary>
    /// This object contains summoner spell list data.
    /// </summary>
    [DataContract]
    public class SummonerSpellListDto : RiotDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "data")]
        public Dictionary<string, SummonerSpellDto> Data { get; set; }

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

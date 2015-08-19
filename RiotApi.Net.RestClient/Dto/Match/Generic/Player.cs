using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains match player information
    /// </summary>
    [DataContract]
    public class Player
    {
        /// <summary>
        /// Match history URI
        /// </summary>
        [DataMember(Name = "matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        /// <summary>
        /// Profile icon ID
        /// </summary>
        [DataMember(Name = "profileIcon")]
        public int ProfileIcon { get; set; }

        /// <summary>
        /// Summoner ID
        /// </summary>
        [DataMember(Name = "summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// Summoner name
        /// </summary>
        [DataMember(Name = "summonerName")]
        public string SummonerName { get; set; }
    }
}

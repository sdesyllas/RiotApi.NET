using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains match player information
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Match history URI
        /// </summary>
        [JsonProperty(PropertyName = "matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        /// <summary>
        /// Profile icon ID
        /// </summary>
        [JsonProperty(PropertyName = "profileIcon")]
        public int ProfileIcon { get; set; }

        /// <summary>
        /// Summoner ID
        /// </summary>
        [JsonProperty(PropertyName = "summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// Summoner name
        /// </summary>
        [JsonProperty(PropertyName = "summonerName")]
        public string SummonerName { get; set; }
    }
}

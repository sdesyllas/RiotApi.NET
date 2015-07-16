using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.Summoner
{
    /// <summary>
    /// This object contains summoner information.
    /// </summary>
    public class SummonerDto : RiotDto
    {
        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        [JsonProperty(PropertyName = "profileIconId")]
        public string ProfileIconId { get; set; }

        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds. 
        /// The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change
        /// </summary>
        [JsonProperty(PropertyName = "revisionDate")]
        public long RevisionDate { get; set; }

        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        [JsonProperty(PropertyName = "summonerLevel")]
        public long SummonerLevel { get; set; }
    }
}

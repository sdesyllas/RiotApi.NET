using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Summoner
{
    /// <summary>
    /// This object contains summoner information.
    /// </summary>
    [DataContract]
    public class SummonerDto : RiotDto
    {
        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// Summoner name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        [DataMember(Name = "profileIconId")]
        public int ProfileIconId { get; set; }

        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds. 
        /// The following events will update this timestamp: profile icon change, playing the tutorial or advanced tutorial, finishing a game, summoner name change
        /// </summary>
        [DataMember(Name = "revisionDate")]
        public long RevisionDate { get; set; }

        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        [DataMember(Name = "summonerLevel")]
        public long SummonerLevel { get; set; }
    }
}

using RiotApi.Net.RestClient.Dto.Stats.Generic;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Stats
{
    /// <summary>
    /// This object contains ranked stats information.
    /// </summary>
    [DataContract]
    public class RankedStatsDto : RiotDto
    {
        /// <summary>
        /// Collection of aggregated stats summarized by champion.
        /// </summary>
        [DataMember(Name = "champions")]
        public IEnumerable<ChampionStatsDto> Champions { get; set; }

        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "modifyDate")]
        public long ModifyDate { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name = "summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// This object contains a collection of champion stats information.
        /// </summary>
        [DataContract]
        public class ChampionStatsDto
        {
            /// <summary>
            /// Champion ID. Note that champion ID 0 represents the combined stats for all champions. 
            /// For static information correlating to champion IDs, please refer to the LoL Static Data API.
            /// </summary>
            [DataMember(Name = "id")]
            public int Id { get; set; }

            /// <summary>
            /// Aggregated stats associated with the champion.
            /// </summary>
            [DataMember(Name = "stats")]
            public AggregatedStatsDto Stats { get; set; }
        }
    }
}

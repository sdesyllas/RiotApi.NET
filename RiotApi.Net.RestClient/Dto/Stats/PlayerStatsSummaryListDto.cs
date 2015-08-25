using RiotApi.Net.RestClient.Dto.Stats.Generic;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Stats
{
    /// <summary>
    /// This object contains a collection of player stats summary information.
    /// </summary>
    [DataContract]
    public class PlayerStatsSummaryListDto : RiotDto
    {
        /// <summary>
        /// Collection of player stats summaries associated with the summoner.
        /// </summary>
        [DataMember(Name = "playerStatSummaries")]
        public IEnumerable<PlayerStatsSummaryDto> PlayerStatSummaries { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name = "summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// This object contains player stats summary information.
        /// </summary>
        [DataContract]
        public class PlayerStatsSummaryDto
        {
            /// <summary>
            /// Aggregated stats.
            /// </summary>
            [DataMember(Name = "aggregatedStats")]
            public AggregatedStatsDto AggregatedStats { get; set; }

            /// <summary>
            /// Number of losses for this queue type. Returned for ranked queue types only.
            /// </summary>
            [DataMember(Name = "losses")]
            public int Losses { get; set; }

            /// <summary>
            /// Date stats were last modified specified as epoch milliseconds.
            /// </summary>
            [DataMember(Name = "modifyDate")]
            public long ModifyDate { get; set; }

            /// <summary>
            /// Player stats summary type. (Legal values: AramUnranked5x5, Ascension, CAP5x5, CoopVsAI, CoopVsAI3x3, CounterPick, FirstBlood1x1, 
            /// FirstBlood2x2, Hexakill, KingPoro, NightmareBot, OdinUnranked, OneForAll5x5, RankedPremade3x3, RankedPremade5x5, RankedSolo5x5,
            ///  RankedTeam3x3, RankedTeam5x5, SummonersRift6x6, Unranked, Unranked3x3, URF, URFBots, Bilgewater)
            /// </summary>
            [DataMember(Name = "playerStatSummaryType")]
            public Helpers.Enums.PlayerStatSummaryType PlayerStatSummaryType { get; set; }

            /// <summary>
            /// Number of wins for this queue type.
            /// </summary>
            [DataMember(Name = "wins")]
            public int Wins { get; set; }
        }
    }
}

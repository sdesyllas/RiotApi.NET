using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RiotApi.Net.RestClient.Dto.Stats.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Net.RestClient.Dto.Stats
{
    /// <summary>
    /// This object contains a collection of player stats summary information.
    /// </summary>
    public class PlayerStatsSummaryListDto : RiotDto
    {
        /// <summary>
        /// Collection of player stats summaries associated with the summoner.
        /// </summary>
        [JsonProperty(PropertyName = "playerStatSummaries")]
        public IEnumerable<PlayerStatsSummaryDto> PlayerStatSummaries { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty(PropertyName = "summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// This object contains player stats summary information.
        /// </summary>
        public class PlayerStatsSummaryDto
        {
            /// <summary>
            /// Aggregated stats.
            /// </summary>
            [JsonProperty(PropertyName = "aggregatedStats")]
            public AggregatedStatsDto AggregatedStats { get; set; }

            /// <summary>
            /// Number of losses for this queue type. Returned for ranked queue types only.
            /// </summary>
            [JsonProperty(PropertyName = "losses")]
            public int? Losses { get; set; }

            /// <summary>
            /// Date stats were last modified specified as epoch milliseconds.
            /// </summary>
            [JsonProperty(PropertyName = "modifyDate")]
            public long ModifyDate { get; set; }

            /// <summary>
            /// Player stats summary type. (Legal values: AramUnranked5x5, Ascension, CAP5x5, CoopVsAI, CoopVsAI3x3, CounterPick, FirstBlood1x1, 
            /// FirstBlood2x2, Hexakill, KingPoro, NightmareBot, OdinUnranked, OneForAll5x5, RankedPremade3x3, RankedPremade5x5, RankedSolo5x5,
            ///  RankedTeam3x3, RankedTeam5x5, SummonersRift6x6, Unranked, Unranked3x3, URF, URFBots)
            /// </summary>
            [JsonProperty(PropertyName = "playerStatSummaryType")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Helpers.Enums.PlayerStatSummaryType PlayerStatSummaryType { get; set; }

            /// <summary>
            /// Number of wins for this queue type.
            /// </summary>
            [JsonProperty(PropertyName = "wins")]
            public int Wins { get; set; }
        }
    }
}

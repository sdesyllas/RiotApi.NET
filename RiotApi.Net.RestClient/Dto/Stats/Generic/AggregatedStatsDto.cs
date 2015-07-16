using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Net.RestClient.Dto.Stats.Generic
{
    /// <summary>
    /// This object contains aggregated stat information.
    /// </summary>
    public class AggregatedStatsDto
    {
        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageAssists")]
        public int AverageAssists { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageChampionsKilled")]
        public int AverageChampionsKilled { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageCombatPlayerScore")]
        public int AverageCombatPlayerScore { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageNodeCapture")]
        public int AverageNodeCapture { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageNodeCaptureAssist")]
        public int AverageNodeCaptureAssist { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageNodeNeutralize")]
        public int AverageNodeNeutralize { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageNodeNeutralizeAssist")]
        public int AverageNodeNeutralizeAssist { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageNumDeaths")]
        public int AverageNumDeaths { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageObjectivePlayerScore")]
        public int AverageObjectivePlayerScore { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageTeamObjective")]
        public int AverageTeamObjective { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "averageTotalPlayerScore")]
        public int AverageTotalPlayerScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "botGamesPlayed")]
        public int BotGamesPlayed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "killingSpree")]
        public int KillingSpree { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "maxAssists")]
        public int MaxAssists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "maxChampionsKilled")]
        public int MaxChampionsKilled { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "maxCombatPlayerScore")]
        public int MaxCombatPlayerScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "maxLargestCriticalStrike")]
        public int MaxLargestCriticalStrike { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "maxLargestKillingSpree")]
        public int maxLargestKillingSpree { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "maxNodeCapture")]
        public int MaxNodeCapture { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "maxNodeCaptureAssist")]
        public int MaxNodeCaptureAssist { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "maxNodeNeutralize")]
        public int MaxNodeNeutralize { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "maxNodeNeutralizeAssist")]
        public int MaxNodeNeutralizeAssist { get; set; }

        /// <summary>
        /// Only returned for ranked statistics.
        /// </summary>
        [JsonProperty(PropertyName = "maxNumDeaths")]
        public int? MaxNumDeaths { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "maxObjectivePlayerScore")]
        public int maxObjectivePlayerScore { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "maxTeamObjective")]
        public int MaxTeamObjective { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "maxTimePlayed")]
        public int MaxTimePlayed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "maxTimeSpentLiving")]
        public int MaxTimeSpentLiving { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "maxTotalPlayerScore")]
        public int MaxTotalPlayerScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "mostChampionKillsPerSession")]
        public int MostChampionKillsPerSession { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "mostSpellsCast")]
        public int MostSpellsCast { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "normalGamesPlayed")]
        public int NormalGamesPlayed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "rankedPremadeGamesPlayed")]
        public int RankedPremadeGamesPlayed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "rankedSoloGamesPlayed")]
        public int RankedSoloGamesPlayed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalAssists")]
        public int TotalAssists { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalChampionKills")]
        public int TotalChampionKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalDamageDealt")]
        public int TotalDamageDealt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalDamageTaken")]
        public int TotalDamageTaken { get; set; }

        /// <summary>
        /// Only returned for ranked statistics.
        /// </summary>
        [JsonProperty(PropertyName = "totalDeathsPerSession")]
        public int? TotalDeathsPerSession { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalDoubleKills")]
        public int TotalDoubleKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalFirstBlood")]
        public int TotalFirstBlood { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalGoldEarned")]
        public int TotalGoldEarned { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalHeal")]
        public int TotalHeal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalMagicDamageDealt")]
        public int TotalMagicDamageDealt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalMinionKills")]
        public int TotalMinionKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalNeutralMinionsKilled")]
        public int TotalNeutralMinionsKilled { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "totalNodeCapture")]
        public int TotalNodeCapture { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [JsonProperty(PropertyName = "totalNodeNeutralize")]
        public int TotalNodeNeutralize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalPentaKills")]
        public int TotalPentaKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalPhysicalDamageDealt")]
        public int TotalPhysicalDamageDealt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalQuadraKills")]
        public int TotalQuadraKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalSessionsLost")]
        public int TotalSessionsLost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalSessionsPlayed")]
        public int TotalSessionsPlayed { get; set; }
        
        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalSessionsWon")]
        public int TotalSessionsWon { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalTripleKills")]
        public int TotalTripleKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalTurretsKilled")]
        public int TotalTurretsKilled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "totalUnrealKills")]
        public int TotalUnrealKills { get; set; }
    }
}

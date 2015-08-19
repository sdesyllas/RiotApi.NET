using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Stats.Generic
{
    /// <summary>
    /// This object contains aggregated stat information.
    /// </summary>
    [DataContract]
    public class AggregatedStatsDto
    {
        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageAssists")]
        public int AverageAssists { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageChampionsKilled")]
        public int AverageChampionsKilled { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageCombatPlayerScore")]
        public int AverageCombatPlayerScore { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageNodeCapture")]
        public int AverageNodeCapture { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageNodeCaptureAssist")]
        public int AverageNodeCaptureAssist { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageNodeNeutralize")]
        public int AverageNodeNeutralize { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageNodeNeutralizeAssist")]
        public int AverageNodeNeutralizeAssist { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageNumDeaths")]
        public int AverageNumDeaths { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageObjectivePlayerScore")]
        public int AverageObjectivePlayerScore { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageTeamObjective")]
        public int AverageTeamObjective { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "averageTotalPlayerScore")]
        public int AverageTotalPlayerScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "botGamesPlayed")]
        public int BotGamesPlayed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "killingSpree")]
        public int KillingSpree { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "maxAssists")]
        public int MaxAssists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "maxChampionsKilled")]
        public int MaxChampionsKilled { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "maxCombatPlayerScore")]
        public int MaxCombatPlayerScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "maxLargestCriticalStrike")]
        public int MaxLargestCriticalStrike { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "maxLargestKillingSpree")]
        public int maxLargestKillingSpree { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "maxNodeCapture")]
        public int MaxNodeCapture { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "maxNodeCaptureAssist")]
        public int MaxNodeCaptureAssist { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "maxNodeNeutralize")]
        public int MaxNodeNeutralize { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "maxNodeNeutralizeAssist")]
        public int MaxNodeNeutralizeAssist { get; set; }

        /// <summary>
        /// Only returned for ranked statistics.
        /// </summary>
        [DataMember(Name = "maxNumDeaths")]
        public int? MaxNumDeaths { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "maxObjectivePlayerScore")]
        public int MaxObjectivePlayerScore { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "maxTeamObjective")]
        public int MaxTeamObjective { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "maxTimePlayed")]
        public int MaxTimePlayed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "maxTimeSpentLiving")]
        public int MaxTimeSpentLiving { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "maxTotalPlayerScore")]
        public int MaxTotalPlayerScore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "mostChampionKillsPerSession")]
        public int MostChampionKillsPerSession { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "mostSpellsCast")]
        public int MostSpellsCast { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "normalGamesPlayed")]
        public int NormalGamesPlayed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "rankedPremadeGamesPlayed")]
        public int RankedPremadeGamesPlayed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "rankedSoloGamesPlayed")]
        public int RankedSoloGamesPlayed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalAssists")]
        public int TotalAssists { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalChampionKills")]
        public int TotalChampionKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalDamageDealt")]
        public int TotalDamageDealt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalDamageTaken")]
        public int TotalDamageTaken { get; set; }

        /// <summary>
        /// Only returned for ranked statistics.
        /// </summary>
        [DataMember(Name = "totalDeathsPerSession")]
        public int? TotalDeathsPerSession { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalDoubleKills")]
        public int TotalDoubleKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalFirstBlood")]
        public int TotalFirstBlood { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalGoldEarned")]
        public int TotalGoldEarned { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalHeal")]
        public int TotalHeal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalMagicDamageDealt")]
        public int TotalMagicDamageDealt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalMinionKills")]
        public int TotalMinionKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalNeutralMinionsKilled")]
        public int TotalNeutralMinionsKilled { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "totalNodeCapture")]
        public int TotalNodeCapture { get; set; }

        /// <summary>
        /// Dominion only.
        /// </summary>
        [DataMember(Name = "totalNodeNeutralize")]
        public int TotalNodeNeutralize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalPentaKills")]
        public int TotalPentaKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalPhysicalDamageDealt")]
        public int TotalPhysicalDamageDealt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalQuadraKills")]
        public int TotalQuadraKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalSessionsLost")]
        public int TotalSessionsLost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalSessionsPlayed")]
        public int TotalSessionsPlayed { get; set; }
        
        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalSessionsWon")]
        public int TotalSessionsWon { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalTripleKills")]
        public int TotalTripleKills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalTurretsKilled")]
        public int TotalTurretsKilled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "totalUnrealKills")]
        public int TotalUnrealKills { get; set; }
    }
}

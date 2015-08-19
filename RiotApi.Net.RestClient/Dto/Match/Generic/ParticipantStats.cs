using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains participant statistics information
    /// </summary>
    [DataContract]
    public class ParticipantStats
    {
        /// <summary>
        /// Number of assists
        /// </summary>
        [DataMember(Name = "assists")]
        public long Assists { get; set; }

        /// <summary>
        /// Champion level achieved
        /// </summary>
        [DataMember(Name = "champLevel")]
        public long ChampLevel { get; set; }

        /// <summary>
        /// If game was a dominion game, player's combat score, otherwise 0
        /// </summary>
        [DataMember(Name = "combatPlayerScore")]
        public long CombatPlayerScore { get; set; }

        /// <summary>
        /// Number of deaths
        /// </summary>
        [DataMember(Name = "deaths")]
        public long Deaths { get; set; }

        /// <summary>
        /// Number of double kills
        /// </summary>
        [DataMember(Name = "doubleKills")]
        public long DoubleKills { get; set; }

        /// <summary>
        /// lag indicating if participant got an assist on first blood
        /// </summary>
        [DataMember(Name = "firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }

        /// <summary>
        /// Flag indicating if participant got first blood
        /// </summary>
        [DataMember(Name = "firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        /// <summary>
        /// Flag indicating if participant got an assist on the first inhibitor
        /// </summary>
        [DataMember(Name = "firstInhibitorAssist")]
        public bool FirstInhibitorAssist { get; set; }

        /// <summary>
        /// Flag indicating if participant destroyed the first inhibitor
        /// </summary>
        [DataMember(Name = "firstInhibitorKill")]
        public bool FirstInhibitorKill { get; set; }

        /// <summary>
        /// Flag indicating if participant got an assist on the first tower
        /// </summary>
        [DataMember(Name = "firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        /// <summary>
        /// Flag indicating if participant destroyed the first tower
        /// </summary>
        [DataMember(Name = "firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        /// <summary>
        /// Gold earned
        /// </summary>
        [DataMember(Name = "goldEarned")]
        public long GoldEarned { get; set; }

        /// <summary>
        /// Gold spent
        /// </summary>
        [DataMember(Name = "goldSpent")]
        public long GoldSpent { get; set; }

        /// <summary>
        /// Number of inhibitor kills
        /// </summary>
        [DataMember(Name = "inhibitorKills")]
        public long InhibitorKills { get; set; }

        /// <summary>
        /// First item ID
        /// </summary>
        [DataMember(Name = "item0")]
        public long Item0 { get; set; }

        /// <summary>
        /// Second item ID
        /// </summary>
        [DataMember(Name = "item1")]
        public long Item1 { get; set; }

        /// <summary>
        /// Third item ID
        /// </summary>
        [DataMember(Name = "item2")]
        public long Item2 { get; set; }

        /// <summary>
        /// Fourth item ID
        /// </summary>
        [DataMember(Name = "item3")]
        public long Item3 { get; set; }

        /// <summary>
        /// Fifth item ID
        /// </summary>
        [DataMember(Name = "item4")]
        public long Item4 { get; set; }

        /// <summary>
        /// Sixth item ID
        /// </summary>
        [DataMember(Name = "item5")]
        public long Item5 { get; set; }

        /// <summary>
        /// Seventh item ID
        /// </summary>
        [DataMember(Name = "item6")]
        public long Item6 { get; set; }

        /// <summary>
        /// Number of killing sprees
        /// </summary>
        [DataMember(Name = "killingSprees")]
        public long KillingSprees { get; set; }

        /// <summary>
        /// Number of kills
        /// </summary>
        [DataMember(Name = "kills")]
        public long Kills { get; set; }

        /// <summary>
        /// Largest critical strike
        /// </summary>
        [DataMember(Name = "largestCriticalStrike")]
        public long LargestCriticalStrike { get; set; }

        /// <summary>
        /// Largest killing spree
        /// </summary>
        [DataMember(Name = "largestKillingSpree")]
        public long LargestKillingSpree { get; set; }

        /// <summary>
        /// Largest multi kill
        /// </summary>
        [DataMember(Name = "largestMultiKill")]
        public long LargestMultiKill { get; set; }

        /// <summary>
        /// Magical damage dealt
        /// </summary>
        [DataMember(Name = "magicDamageDealt")]
        public long magicDamageDealt { get; set; }

        /// <summary>
        /// Magical damage dealt to champions
        /// </summary>
        [DataMember(Name = "magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        /// <summary>
        /// Magic damage taken
        /// </summary>
        [DataMember(Name = "magicDamageTaken")]
        public long MagicDamageTaken { get; set; }

        /// <summary>
        /// Minions killed
        /// </summary>
        [DataMember(Name = "minionsKilled")]
        public long MinionsKilled { get; set; }

        /// <summary>
        /// Neutral minions killed
        /// </summary>
        [DataMember(Name = "neutralMinionsKilled")]
        public long NeutralMinionsKilled { get; set; }

        /// <summary>
        /// Neutral jungle minions killed in the enemy team's jungle
        /// </summary>
        [DataMember(Name = "neutralMinionsKilledEnemyJungle")]
        public long NeutralMinionsKilledEnemyJungle { get; set; }

        /// <summary>
        /// Neutral jungle minions killed in your team's jungle
        /// </summary>
        [DataMember(Name = "neutralMinionsKilledTeamJungle")]
        public long NeutralMinionsKilledTeamJungle { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node captures
        /// </summary>
        [DataMember(Name = "nodeCapture")]
        public long NodeCapture { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node capture assists
        /// </summary>
        [DataMember(Name = "nodeCaptureAssist")]
        public long NodeCaptureAssist { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node neutralizations
        /// </summary>
        [DataMember(Name = "nodeNeutralize")]
        public long NodeNeutralize { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node neutralization assists
        /// </summary>
        [DataMember(Name = "nodeNeutralizeAssist")]
        public long NodeNeutralizeAssist { get; set; }

        /// <summary>
        /// If game was a dominion game, player's objectives score, otherwise 0
        /// </summary>
        [DataMember(Name = "objectivePlayerScore")]
        public long ObjectivePlayerScore { get; set; }

        /// <summary>
        /// Number of penta kills
        /// </summary>
        [DataMember(Name = "pentaKills")]
        public long PentaKills { get; set; }

        /// <summary>
        /// Physical damage dealt
        /// </summary>
        [DataMember(Name = "physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }

        /// <summary>
        /// Physical damage dealt to champions
        /// </summary>
        [DataMember(Name = "physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Physical damage taken
        /// </summary>
        [DataMember(Name = "physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }

        /// <summary>
        /// Number of quadra kills
        /// </summary>
        [DataMember(Name = "quadraKills")]
        public long QuadraKills { get; set; }

        /// <summary>
        /// Sight wards purchased
        /// </summary>
        [DataMember(Name = "sightWardsBoughtInGame")]
        public long SightWardsBoughtInGame { get; set; }

        /// <summary>
        /// If game was a dominion game, number of completed team objectives (i.e., quests)
        /// </summary>
        [DataMember(Name = "teamObjective")]
        public long TeamObjective { get; set; }

        /// <summary>
        /// Total damage dealt
        /// </summary>
        [DataMember(Name = "totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        /// <summary>
        /// Total damage dealt to champions
        /// </summary>
        [DataMember(Name = "totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Total damage taken
        /// </summary>
        [DataMember(Name = "totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        /// <summary>
        /// Total heal amount
        /// </summary>
        [DataMember(Name = "totalHeal")]
        public long TotalHeal { get; set; }

        /// <summary>
        /// If game was a dominion game, player's total score, otherwise 0
        /// </summary>
        [DataMember(Name = "totalPlayerScore")]
        public long TotalPlayerScore { get; set; }

        /// <summary>
        /// If game was a dominion game, team rank of the player's total score (e.g., 1-5)
        /// </summary>
        [DataMember(Name = "totalScoreRank")]
        public long TotalScoreRank { get; set; }

        /// <summary>
        /// Total dealt crowd control time
        /// </summary>
        [DataMember(Name = "totalTimeCrowdControlDealt")]
        public long TotalTimeCrowdControlDealt { get; set; }

        /// <summary>
        /// Total units healed
        /// </summary>
        [DataMember(Name = "totalUnitsHealed")]
        public long TotalUnitsHealed { get; set; }

        /// <summary>
        /// Number of tower kills
        /// </summary>
        [DataMember(Name = "towerKills")]
        public long TowerKills { get; set; }

        /// <summary>
        /// Number of triple kills
        /// </summary>
        [DataMember(Name = "tripleKills")]
        public long TripleKills { get; set; }

        /// <summary>
        /// True damage dealt to champions
        /// </summary>
        [DataMember(Name = "trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        /// <summary>
        /// True damage taken
        /// </summary>
        [DataMember(Name = "trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        /// <summary>
        /// Number of unreal kills
        /// </summary>
        [DataMember(Name = "unrealKills")]
        public long UnrealKills { get; set; }

        /// <summary>
        /// Vision wards purchased
        /// </summary>
        [DataMember(Name = "visionWardsBoughtInGame")]
        public long VisionWardsBoughtInGame { get; set; }

        /// <summary>
        /// Number of wards killed
        /// </summary>
        [DataMember(Name = "wardsKilled")]
        public long WardsKilled { get; set; }

        /// <summary>
        /// Number of wards placed
        /// </summary>
        [DataMember(Name = "wardsPlaced")]
        public long WardsPlaced { get; set; }

        /// <summary>
        /// Flag indicating whether or not the participant won
        /// </summary>
        [DataMember(Name = "winner")]
        public bool Winner { get; set; }
    }
}

using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains participant statistics information
    /// </summary>
    public class ParticipantStats
    {
        /// <summary>
        /// Number of assists
        /// </summary>
        [JsonProperty(PropertyName = "assists")]
        public long Assists { get; set; }

        /// <summary>
        /// Champion level achieved
        /// </summary>
        [JsonProperty(PropertyName = "champLevel")]
        public long ChampLevel { get; set; }

        /// <summary>
        /// If game was a dominion game, player's combat score, otherwise 0
        /// </summary>
        [JsonProperty(PropertyName = "combatPlayerScore")]
        public long CombatPlayerScore { get; set; }

        /// <summary>
        /// Number of deaths
        /// </summary>
        [JsonProperty(PropertyName = "deaths")]
        public long Deaths { get; set; }

        /// <summary>
        /// Number of double kills
        /// </summary>
        [JsonProperty(PropertyName = "doubleKills")]
        public long DoubleKills { get; set; }

        /// <summary>
        /// lag indicating if participant got an assist on first blood
        /// </summary>
        [JsonProperty(PropertyName = "firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }

        /// <summary>
        /// Flag indicating if participant got first blood
        /// </summary>
        [JsonProperty(PropertyName = "firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        /// <summary>
        /// Flag indicating if participant got an assist on the first inhibitor
        /// </summary>
        [JsonProperty(PropertyName = "firstInhibitorAssist")]
        public bool FirstInhibitorAssist { get; set; }

        /// <summary>
        /// Flag indicating if participant destroyed the first inhibitor
        /// </summary>
        [JsonProperty(PropertyName = "firstInhibitorKill")]
        public bool FirstInhibitorKill { get; set; }

        /// <summary>
        /// Flag indicating if participant got an assist on the first tower
        /// </summary>
        [JsonProperty(PropertyName = "firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        /// <summary>
        /// Flag indicating if participant destroyed the first tower
        /// </summary>
        [JsonProperty(PropertyName = "firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        /// <summary>
        /// Gold earned
        /// </summary>
        [JsonProperty(PropertyName = "goldEarned")]
        public long GoldEarned { get; set; }

        /// <summary>
        /// Gold spent
        /// </summary>
        [JsonProperty(PropertyName = "goldSpent")]
        public long GoldSpent { get; set; }

        /// <summary>
        /// Number of inhibitor kills
        /// </summary>
        [JsonProperty(PropertyName = "inhibitorKills")]
        public long InhibitorKills { get; set; }

        /// <summary>
        /// First item ID
        /// </summary>
        [JsonProperty(PropertyName = "item0")]
        public long Item0 { get; set; }

        /// <summary>
        /// Second item ID
        /// </summary>
        [JsonProperty(PropertyName = "item1")]
        public long Item1 { get; set; }

        /// <summary>
        /// Third item ID
        /// </summary>
        [JsonProperty(PropertyName = "item2")]
        public long Item2 { get; set; }

        /// <summary>
        /// Fourth item ID
        /// </summary>
        [JsonProperty(PropertyName = "item3")]
        public long Item3 { get; set; }

        /// <summary>
        /// Fifth item ID
        /// </summary>
        [JsonProperty(PropertyName = "item4")]
        public long Item4 { get; set; }

        /// <summary>
        /// Sixth item ID
        /// </summary>
        [JsonProperty(PropertyName = "item5")]
        public long Item5 { get; set; }

        /// <summary>
        /// Seventh item ID
        /// </summary>
        [JsonProperty(PropertyName = "item6")]
        public long Item6 { get; set; }

        /// <summary>
        /// Number of killing sprees
        /// </summary>
        [JsonProperty(PropertyName = "killingSprees")]
        public long KillingSprees { get; set; }

        /// <summary>
        /// Number of kills
        /// </summary>
        [JsonProperty(PropertyName = "kills")]
        public long Kills { get; set; }

        /// <summary>
        /// Largest critical strike
        /// </summary>
        [JsonProperty(PropertyName = "largestCriticalStrike")]
        public long LargestCriticalStrike { get; set; }

        /// <summary>
        /// Largest killing spree
        /// </summary>
        [JsonProperty(PropertyName = "largestKillingSpree")]
        public long LargestKillingSpree { get; set; }

        /// <summary>
        /// Largest multi kill
        /// </summary>
        [JsonProperty(PropertyName = "largestMultiKill")]
        public long LargestMultiKill { get; set; }

        /// <summary>
        /// Magical damage dealt
        /// </summary>
        [JsonProperty(PropertyName = "magicDamageDealt")]
        public long magicDamageDealt { get; set; }

        /// <summary>
        /// Magical damage dealt to champions
        /// </summary>
        [JsonProperty(PropertyName = "magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        /// <summary>
        /// Magic damage taken
        /// </summary>
        [JsonProperty(PropertyName = "magicDamageTaken")]
        public long MagicDamageTaken { get; set; }

        /// <summary>
        /// Minions killed
        /// </summary>
        [JsonProperty(PropertyName = "minionsKilled")]
        public long MinionsKilled { get; set; }

        /// <summary>
        /// Neutral minions killed
        /// </summary>
        [JsonProperty(PropertyName = "neutralMinionsKilled")]
        public long NeutralMinionsKilled { get; set; }

        /// <summary>
        /// Neutral jungle minions killed in the enemy team's jungle
        /// </summary>
        [JsonProperty(PropertyName = "neutralMinionsKilledEnemyJungle")]
        public long NeutralMinionsKilledEnemyJungle { get; set; }

        /// <summary>
        /// Neutral jungle minions killed in your team's jungle
        /// </summary>
        [JsonProperty(PropertyName = "neutralMinionsKilledTeamJungle")]
        public long NeutralMinionsKilledTeamJungle { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node captures
        /// </summary>
        [JsonProperty(PropertyName = "nodeCapture")]
        public long NodeCapture { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node capture assists
        /// </summary>
        [JsonProperty(PropertyName = "nodeCaptureAssist")]
        public long NodeCaptureAssist { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node neutralizations
        /// </summary>
        [JsonProperty(PropertyName = "nodeNeutralize")]
        public long NodeNeutralize { get; set; }

        /// <summary>
        /// If game was a dominion game, number of node neutralization assists
        /// </summary>
        [JsonProperty(PropertyName = "nodeNeutralizeAssist")]
        public long NodeNeutralizeAssist { get; set; }

        /// <summary>
        /// If game was a dominion game, player's objectives score, otherwise 0
        /// </summary>
        [JsonProperty(PropertyName = "objectivePlayerScore")]
        public long ObjectivePlayerScore { get; set; }

        /// <summary>
        /// Number of penta kills
        /// </summary>
        [JsonProperty(PropertyName = "pentaKills")]
        public long PentaKills { get; set; }

        /// <summary>
        /// Physical damage dealt
        /// </summary>
        [JsonProperty(PropertyName = "physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }

        /// <summary>
        /// Physical damage dealt to champions
        /// </summary>
        [JsonProperty(PropertyName = "physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Physical damage taken
        /// </summary>
        [JsonProperty(PropertyName = "physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }

        /// <summary>
        /// Number of quadra kills
        /// </summary>
        [JsonProperty(PropertyName = "quadraKills")]
        public long QuadraKills { get; set; }

        /// <summary>
        /// Sight wards purchased
        /// </summary>
        [JsonProperty(PropertyName = "sightWardsBoughtInGame")]
        public long SightWardsBoughtInGame { get; set; }

        /// <summary>
        /// If game was a dominion game, number of completed team objectives (i.e., quests)
        /// </summary>
        [JsonProperty(PropertyName = "teamObjective")]
        public long TeamObjective { get; set; }

        /// <summary>
        /// Total damage dealt
        /// </summary>
        [JsonProperty(PropertyName = "totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        /// <summary>
        /// Total damage dealt to champions
        /// </summary>
        [JsonProperty(PropertyName = "totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        /// <summary>
        /// Total damage taken
        /// </summary>
        [JsonProperty(PropertyName = "totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        /// <summary>
        /// Total heal amount
        /// </summary>
        [JsonProperty(PropertyName = "totalHeal")]
        public long TotalHeal { get; set; }

        /// <summary>
        /// If game was a dominion game, player's total score, otherwise 0
        /// </summary>
        [JsonProperty(PropertyName = "totalPlayerScore")]
        public long TotalPlayerScore { get; set; }

        /// <summary>
        /// If game was a dominion game, team rank of the player's total score (e.g., 1-5)
        /// </summary>
        [JsonProperty(PropertyName = "totalScoreRank")]
        public long TotalScoreRank { get; set; }

        /// <summary>
        /// Total dealt crowd control time
        /// </summary>
        [JsonProperty(PropertyName = "totalTimeCrowdControlDealt")]
        public long TotalTimeCrowdControlDealt { get; set; }

        /// <summary>
        /// Total units healed
        /// </summary>
        [JsonProperty(PropertyName = "totalUnitsHealed")]
        public long TotalUnitsHealed { get; set; }

        /// <summary>
        /// Number of tower kills
        /// </summary>
        [JsonProperty(PropertyName = "towerKills")]
        public long TowerKills { get; set; }

        /// <summary>
        /// Number of triple kills
        /// </summary>
        [JsonProperty(PropertyName = "tripleKills")]
        public long TripleKills { get; set; }

        /// <summary>
        /// True damage dealt to champions
        /// </summary>
        [JsonProperty(PropertyName = "trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        /// <summary>
        /// True damage taken
        /// </summary>
        [JsonProperty(PropertyName = "trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        /// <summary>
        /// Number of unreal kills
        /// </summary>
        [JsonProperty(PropertyName = "unrealKills")]
        public long UnrealKills { get; set; }

        /// <summary>
        /// Vision wards purchased
        /// </summary>
        [JsonProperty(PropertyName = "visionWardsBoughtInGame")]
        public long VisionWardsBoughtInGame { get; set; }

        /// <summary>
        /// Number of wards killed
        /// </summary>
        [JsonProperty(PropertyName = "wardsKilled")]
        public long WardsKilled { get; set; }

        /// <summary>
        /// Number of wards placed
        /// </summary>
        [JsonProperty(PropertyName = "wardsPlaced")]
        public long WardsPlaced { get; set; }

        /// <summary>
        /// Flag indicating whether or not the participant won
        /// </summary>
        [JsonProperty(PropertyName = "winner")]
        public bool Winner { get; set; }
    }
}

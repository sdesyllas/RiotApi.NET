using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Game
{
    /// <summary>
    /// RecentGamesDto
    /// </summary>
    public class RecentGamesDto : RiotDto
    {
        /// <summary>
        /// Collection of recent games played (max 10).
        /// </summary>
        [JsonProperty(PropertyName = "games")]
        public IEnumerable<GameDto> Games { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty(PropertyName = "summonerId")]
        public IEnumerable<GameDto> SummonerId { get; set; }

        /// <summary>
        /// GameDto  This object contains game information.
        /// </summary>
        public class GameDto
        {
            /// <summary>
            /// Champion ID associated with game.
            /// </summary>
            [JsonProperty(PropertyName = "championId")]
            public int ChampionId { get; set; }

            /// <summary>
            /// Date that end game data was recorded, specified as epoch milliseconds.
            /// </summary>
            [JsonProperty(PropertyName = "createDate")]
            public long CreateDate { get; set; }

            /// <summary>
            /// Other players associated with the game.
            /// </summary>
            [JsonProperty(PropertyName = "fellowPlayers")]
            public IEnumerable<PlayerDto> FellowPlayers { get; set; }

            /// <summary>
            /// Game ID.
            /// </summary>
            [JsonProperty(PropertyName = "gameId")]
            public long GameId { get; set; }

            /// <summary>
            /// Game mode. (Legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
            /// </summary>
            [JsonProperty(PropertyName = "gameMode")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Helpers.Enums.GameMode GameMode { get; set; }

            /// <summary>
            /// Game type. (Legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
            /// </summary>
            [JsonProperty(PropertyName = "gameType")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Helpers.Enums.GameType GameType { get; set; }

            /// <summary>
            /// Invalid flag.
            /// </summary>
            [JsonProperty(PropertyName = "invalid")]
            public bool Invalid { get; set; }

            /// <summary>
            /// IP Earned.
            /// </summary>
            [JsonProperty(PropertyName = "ipEarned")]
            public int IpEarned { get; set; }

            /// <summary>
            /// Level.
            /// </summary>
            [JsonProperty(PropertyName = "level")]
            public int Level { get; set; }

            /// <summary>
            /// Map ID.
            /// </summary>
            [JsonProperty(PropertyName = "mapId")]
            public int MapId { get; set; }

            /// <summary>
            /// ID of first summoner spell.
            /// </summary>
            [JsonProperty(PropertyName = "spell1")]
            public int Spell1 { get; set; }

            /// <summary>
            /// ID of second summoner spell.
            /// </summary>
            [JsonProperty(PropertyName = "spell2")]
            public int Spell2 { get; set; }

            /// <summary>
            /// Statistics associated with the game for this summoner.
            /// </summary>
            [JsonProperty(PropertyName = "stats")]
            public RawStatsDto Stats { get; set; }

            /// <summary>
            /// Game sub-type. (Legal values: NONE, NORMAL, BOT, RANKED_SOLO_5x5, RANKED_PREMADE_3x3, RANKED_PREMADE_5x5, ODIN_UNRANKED, RANKED_TEAM_3x3, RANKED_TEAM_5x5, NORMAL_3x3, BOT_3x3, CAP_5x5, ARAM_UNRANKED_5x5, ONEFORALL_5x5, FIRSTBLOOD_1x1, FIRSTBLOOD_2x2, SR_6x6, URF, URF_BOT, NIGHTMARE_BOT, ASCENSION, HEXAKILL, KING_PORO, COUNTER_PICK)
            /// </summary>
            [JsonProperty(PropertyName = "subType")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Helpers.Enums.GameSubType SubType { get; set; }

            /// <summary>
            /// Team ID associated with game. Team ID 100 is blue team. Team ID 200 is purple team.
            /// </summary>
            [JsonProperty(PropertyName = "teamId")]
            public int TeamId { get; set; }
        }

        /// <summary>
        /// PlayerDto This object contains player information.
        /// </summary>
        public class PlayerDto
        {
            /// <summary>
            /// Champion id associated with player.
            /// </summary>
            [JsonProperty(PropertyName = "championId")]
            public int ChampionId { get; set; }

            /// <summary>
            /// Summoner id associated with player.
            /// </summary>
            [JsonProperty(PropertyName = "summonerId")]
            public long SummonerId { get; set; }

            /// <summary>
            /// Team id associated with player.
            /// </summary>
            [JsonProperty(PropertyName = "teamId")]
            public int TeamId { get; set; }
        }

        /// <summary>
        /// RawStatsDto This object contains raw stat information.
        /// </summary>
        public class RawStatsDto
        {
            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "assists")]
            public int Assists { get; set; }

            /// <summary>
            /// Number of enemy inhibitors killed.
            /// </summary>
            [JsonProperty(PropertyName = "barracksKilled")]
            public int BarracksKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "championsKilled")]
            public int ChampionsKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "combatPlayerScore")]
            public int CombatPlayerScore { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "consumablesPurchased")]
            public int ConsumablesPurchased { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "damageDealtPlayer")]
            public int DamageDealtPlayer { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "doubleKills")]
            public int DoubleKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "firstBlood")]
            public int FirstBlood { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "gold")]
            public int Gold { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "goldEarned")]
            public int GoldEarned { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "goldSpent")]
            public int GoldSpent { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "item0")]
            public int Item0 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "item1")]
            public int Item1 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "item2")]
            public int Item2 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "item3")]
            public int Item3 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "item4")]
            public int Item4 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "item5")]
            public int Item5 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "item6")]
            public int Item6 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "itemsPurchased")]
            public int ItemsPurchased { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "killingSprees")]
            public int KillingSprees { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "largestCriticalStrike")]
            public int LargestCriticalStrike { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "largestKillingSpree")]
            public int LargestKillingSpree { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "largestMultiKill")]
            public int LargestMultiKill { get; set; }

            /// <summary>
            /// Number of tier 3 items built.
            /// </summary>
            [JsonProperty(PropertyName = "legendaryItemsCreated")]
            public int LegendaryItemsCreated { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "level")]
            public int Level { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "magicDamageDealtPlayer")]
            public int MagicDamageDealtPlayer { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "magicDamageDealtToChampions")]
            public int MagicDamageDealtToChampions { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "magicDamageTaken")]
            public int MagicDamageTaken { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "minionsDenied")]
            public int MinionsDenied { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "minionsKilled")]
            public int MinionsKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "neutralMinionsKilled")]
            public int NeutralMinionsKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "neutralMinionsKilledEnemyJungle")]
            public int NeutralMinionsKilledEnemyJungle { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "neutralMinionsKilledYourJungle")]
            public int NeutralMinionsKilledYourJungle { get; set; }

            /// <summary>
            /// Flag specifying if the summoner got the killing blow on the nexus.
            /// </summary>
            [JsonProperty(PropertyName = "nexusKilled")]
            public bool NexusKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "nodeCapture")]
            public int NodeCapture { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "nodeCaptureAssist")]
            public int NodeCaptureAssist { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "nodeNeutralize")]
            public int NodeNeutralize { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "nodeNeutralizeAssist")]
            public int NodeNeutralizeAssist { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "numDeaths")]
            public int NumDeaths { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "numItemsBought")]
            public int NumItemsBought { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "objectivePlayerScore")]
            public int ObjectivePlayerScore { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "pentaKills")]
            public int PentaKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "physicalDamageDealtPlayer")]
            public int PhysicalDamageDealtPlayer { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "physicalDamageDealtToChampions")]
            public int PhysicalDamageDealtToChampions { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "physicalDamageTaken")]
            public int PhysicalDamageTaken { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "playerPosition")]
            public int PlayerPosition { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "playerRole")]
            public int PlayerRole { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "quadraKills")]
            public int QuadraKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "sightWardsBought")]
            public int SightWardsBought { get; set; }

            /// <summary>
            /// Number of times first champion spell was cast.
            /// </summary>
            [JsonProperty(PropertyName = "spell1Cast")]
            public int Spell1Cast { get; set; }

            /// <summary>
            /// Number of times second champion spell was cast.
            /// </summary>
            [JsonProperty(PropertyName = "spell2Cast")]
            public int Spell2Cast { get; set; }

            /// <summary>
            /// Number of times third champion spell was cast.
            /// </summary>
            [JsonProperty(PropertyName = "spell3Cast")]
            public int Spell3Cast { get; set; }

            /// <summary>
            /// Number of times fourth champion spell was cast.
            /// </summary>
            [JsonProperty(PropertyName = "spell4Cast")]
            public int Spell4Cast { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "summonSpell1Cast")]
            public int SummonSpell1Cast { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "summonSpell2Cast")]
            public int SummonSpell2Cast { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "superMonsterKilled")]
            public int SuperMonsterKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "team")]
            public int Team { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "teamObjective")]
            public int TeamObjective { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "timePlayed")]
            public int TimePlayed { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "totalDamageDealt")]
            public int TotalDamageDealt { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "totalDamageDealtToChampions")]
            public int TotalDamageDealtToChampions { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "totalDamageTaken")]
            public int TotalDamageTaken { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "totalHeal")]
            public int TotalHeal { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "totalPlayerScore")]
            public int TotalPlayerScore { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "totalScoreRank")]
            public int TotalScoreRank { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "totalTimeCrowdControlDealt")]
            public int TotalTimeCrowdControlDealt { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "totalUnitsHealed")]
            public int TotalUnitsHealed { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "tripleKills")]
            public int TripleKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "trueDamageDealtPlayer")]
            public int TrueDamageDealtPlayer { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "trueDamageDealtToChampions")]
            public int TrueDamageDealtToChampions { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "trueDamageTaken")]
            public int TrueDamageTaken { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "turretsKilled")]
            public int TurretsKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "unrealKills")]
            public int UnrealKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "victoryPointTotal")]
            public int VictoryPointTotal { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "visionWardsBought")]
            public int VisionWardsBought { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "wardKilled")]
            public int WardKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "wardPlaced")]
            public int WardPlaced { get; set; }

            /// <summary>
            /// Flag specifying whether or not this game was won.
            /// </summary>
            [JsonProperty(PropertyName = "win")]
            public bool Win { get; set; }
        }
    }
}

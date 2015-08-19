using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Game
{
    /// <summary>
    /// RecentGamesDto
    /// </summary>
    [DataContract]
    public class RecentGamesDto : RiotDto
    {
        /// <summary>
        /// Collection of recent games played (max 10).
        /// </summary>
        [DataMember(Name = "games")]
        public IEnumerable<GameDto> Games { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name = "summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// GameDto  This object contains game information.
        /// </summary>
        [DataContract]
        public class GameDto
        {
            /// <summary>
            /// Champion ID associated with game.
            /// </summary>
            [DataMember(Name = "championId")]
            public int ChampionId { get; set; }

            /// <summary>
            /// Date that end game data was recorded, specified as epoch milliseconds.
            /// </summary>
            [DataMember(Name = "createDate")]
            public long CreateDate { get; set; }

            /// <summary>
            /// Other players associated with the game.
            /// </summary>
            [DataMember(Name = "fellowPlayers")]
            public IEnumerable<PlayerDto> FellowPlayers { get; set; }

            /// <summary>
            /// Game ID.
            /// </summary>
            [DataMember(Name = "gameId")]
            public long GameId { get; set; }

            /// <summary>
            /// Game mode. (Legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
            /// </summary>
            [DataMember(Name = "gameMode")]
            public Helpers.Enums.GameMode GameMode { get; set; }

            /// <summary>
            /// Game type. (Legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
            /// </summary>
            [DataMember(Name = "gameType")]
            public Helpers.Enums.GameType GameType { get; set; }

            /// <summary>
            /// Invalid flag.
            /// </summary>
            [DataMember(Name = "invalid")]
            public bool Invalid { get; set; }

            /// <summary>
            /// IP Earned.
            /// </summary>
            [DataMember(Name = "ipEarned")]
            public int IpEarned { get; set; }

            /// <summary>
            /// Level.
            /// </summary>
            [DataMember(Name = "level")]
            public int Level { get; set; }

            /// <summary>
            /// Map ID.
            /// </summary>
            [DataMember(Name = "mapId")]
            public int MapId { get; set; }

            /// <summary>
            /// ID of first summoner spell.
            /// </summary>
            [DataMember(Name = "spell1")]
            public int Spell1 { get; set; }

            /// <summary>
            /// ID of second summoner spell.
            /// </summary>
            [DataMember(Name = "spell2")]
            public int Spell2 { get; set; }

            /// <summary>
            /// Statistics associated with the game for this summoner.
            /// </summary>
            [DataMember(Name = "stats")]
            public RawStatsDto Stats { get; set; }

            /// <summary>
            /// Game sub-type. (Legal values: NONE, NORMAL, BOT, RANKED_SOLO_5x5, RANKED_PREMADE_3x3, RANKED_PREMADE_5x5, ODIN_UNRANKED, RANKED_TEAM_3x3, RANKED_TEAM_5x5, NORMAL_3x3, BOT_3x3, CAP_5x5, ARAM_UNRANKED_5x5, ONEFORALL_5x5, FIRSTBLOOD_1x1, FIRSTBLOOD_2x2, SR_6x6, URF, URF_BOT, NIGHTMARE_BOT, ASCENSION, HEXAKILL, KING_PORO, COUNTER_PICK)
            /// </summary>
            [DataMember(Name = "subType")]
            public Helpers.Enums.GameSubType SubType { get; set; }

            /// <summary>
            /// Team ID associated with game. Team ID 100 is blue team. Team ID 200 is purple team.
            /// </summary>
            [DataMember(Name = "teamId")]
            public int TeamId { get; set; }
        }

        /// <summary>
        /// PlayerDto This object contains player information.
        /// </summary>
        [DataContract]
        public class PlayerDto
        {
            /// <summary>
            /// Champion id associated with player.
            /// </summary>
            [DataMember(Name = "championId")]
            public int ChampionId { get; set; }

            /// <summary>
            /// Summoner id associated with player.
            /// </summary>
            [DataMember(Name = "summonerId")]
            public long SummonerId { get; set; }

            /// <summary>
            /// Team id associated with player.
            /// </summary>
            [DataMember(Name = "teamId")]
            public int TeamId { get; set; }
        }

        /// <summary>
        /// RawStatsDto This object contains raw stat information.
        /// </summary>
        [DataContract]
        public class RawStatsDto
        {
            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "assists")]
            public int Assists { get; set; }

            /// <summary>
            /// Number of enemy inhibitors killed.
            /// </summary>
            [DataMember(Name = "barracksKilled")]
            public int BarracksKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "championsKilled")]
            public int ChampionsKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "combatPlayerScore")]
            public int CombatPlayerScore { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "consumablesPurchased")]
            public int ConsumablesPurchased { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "damageDealtPlayer")]
            public int DamageDealtPlayer { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "doubleKills")]
            public int DoubleKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "firstBlood")]
            public int FirstBlood { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "gold")]
            public int Gold { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "goldEarned")]
            public int GoldEarned { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "goldSpent")]
            public int GoldSpent { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "item0")]
            public int Item0 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "item1")]
            public int Item1 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "item2")]
            public int Item2 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "item3")]
            public int Item3 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "item4")]
            public int Item4 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "item5")]
            public int Item5 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "item6")]
            public int Item6 { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "itemsPurchased")]
            public int ItemsPurchased { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "killingSprees")]
            public int KillingSprees { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "largestCriticalStrike")]
            public int LargestCriticalStrike { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "largestKillingSpree")]
            public int LargestKillingSpree { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "largestMultiKill")]
            public int LargestMultiKill { get; set; }

            /// <summary>
            /// Number of tier 3 items built.
            /// </summary>
            [DataMember(Name = "legendaryItemsCreated")]
            public int LegendaryItemsCreated { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "level")]
            public int Level { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "magicDamageDealtPlayer")]
            public int MagicDamageDealtPlayer { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "magicDamageDealtToChampions")]
            public int MagicDamageDealtToChampions { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "magicDamageTaken")]
            public int MagicDamageTaken { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "minionsDenied")]
            public int MinionsDenied { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "minionsKilled")]
            public int MinionsKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "neutralMinionsKilled")]
            public int NeutralMinionsKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "neutralMinionsKilledEnemyJungle")]
            public int NeutralMinionsKilledEnemyJungle { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "neutralMinionsKilledYourJungle")]
            public int NeutralMinionsKilledYourJungle { get; set; }

            /// <summary>
            /// Flag specifying if the summoner got the killing blow on the nexus.
            /// </summary>
            [DataMember(Name = "nexusKilled")]
            public bool NexusKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "nodeCapture")]
            public int NodeCapture { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "nodeCaptureAssist")]
            public int NodeCaptureAssist { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "nodeNeutralize")]
            public int NodeNeutralize { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "nodeNeutralizeAssist")]
            public int NodeNeutralizeAssist { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "numDeaths")]
            public int NumDeaths { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "numItemsBought")]
            public int NumItemsBought { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "objectivePlayerScore")]
            public int ObjectivePlayerScore { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "pentaKills")]
            public int PentaKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "physicalDamageDealtPlayer")]
            public int PhysicalDamageDealtPlayer { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "physicalDamageDealtToChampions")]
            public int PhysicalDamageDealtToChampions { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "physicalDamageTaken")]
            public int PhysicalDamageTaken { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "playerPosition")]
            public int PlayerPosition { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "playerRole")]
            public int PlayerRole { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "quadraKills")]
            public int QuadraKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "sightWardsBought")]
            public int SightWardsBought { get; set; }

            /// <summary>
            /// Number of times first champion spell was cast.
            /// </summary>
            [DataMember(Name = "spell1Cast")]
            public int Spell1Cast { get; set; }

            /// <summary>
            /// Number of times second champion spell was cast.
            /// </summary>
            [DataMember(Name = "spell2Cast")]
            public int Spell2Cast { get; set; }

            /// <summary>
            /// Number of times third champion spell was cast.
            /// </summary>
            [DataMember(Name = "spell3Cast")]
            public int Spell3Cast { get; set; }

            /// <summary>
            /// Number of times fourth champion spell was cast.
            /// </summary>
            [DataMember(Name = "spell4Cast")]
            public int Spell4Cast { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "summonSpell1Cast")]
            public int SummonSpell1Cast { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "summonSpell2Cast")]
            public int SummonSpell2Cast { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "superMonsterKilled")]
            public int SuperMonsterKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "team")]
            public int Team { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "teamObjective")]
            public int TeamObjective { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "timePlayed")]
            public int TimePlayed { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "totalDamageDealt")]
            public int TotalDamageDealt { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "totalDamageDealtToChampions")]
            public int TotalDamageDealtToChampions { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "totalDamageTaken")]
            public int TotalDamageTaken { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "totalHeal")]
            public int TotalHeal { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "totalPlayerScore")]
            public int TotalPlayerScore { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "totalScoreRank")]
            public int TotalScoreRank { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "totalTimeCrowdControlDealt")]
            public int TotalTimeCrowdControlDealt { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "totalUnitsHealed")]
            public int TotalUnitsHealed { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "tripleKills")]
            public int TripleKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "trueDamageDealtPlayer")]
            public int TrueDamageDealtPlayer { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "trueDamageDealtToChampions")]
            public int TrueDamageDealtToChampions { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "trueDamageTaken")]
            public int TrueDamageTaken { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "turretsKilled")]
            public int TurretsKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "unrealKills")]
            public int UnrealKills { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "victoryPointTotal")]
            public int VictoryPointTotal { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "visionWardsBought")]
            public int VisionWardsBought { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "wardKilled")]
            public int WardKilled { get; set; }

            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "wardPlaced")]
            public int WardPlaced { get; set; }

            /// <summary>
            /// Flag specifying whether or not this game was won.
            /// </summary>
            [DataMember(Name = "win")]
            public bool Win { get; set; }
        }
    }
}

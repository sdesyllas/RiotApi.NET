using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Helpers
{
    /// <summary>
    /// All enumerations for the REST api needs
    /// </summary>
    public class Enums
    {
        public enum GameMode
        {
            CLASSIC,
            ODIN,
            ARAM,
            TUTORIAL,
            ONEFORALL,
            ASCENSION,
            FIRSTBLOOD,
            KINGPORO
        }

        public enum GameType
        {
            CUSTOM_GAME,
            MATCHED_GAME,
            TUTORIAL_GAME
        }

        public enum GameSubType
        {
            NONE,
            NORMAL,
            BOT,
            RANKED_SOLO_5x5,
            RANKED_PREMADE_3x3,
            RANKED_PREMADE_5x5,
            ODIN_UNRANKED,
            RANKED_TEAM_3x3,
            RANKED_TEAM_5x5,
            NORMAL_3x3,
            BOT_3x3,
            CAP_5x5,
            ARAM_UNRANKED_5x5,
            ONEFORALL_5x5,
            FIRSTBLOOD_1x1,
            FIRSTBLOOD_2x2,
            SR_6x6,
            URF,
            URF_BOT,
            NIGHTMARE_BOT,
            ASCENSION,
            HEXAKILL,
            KING_PORO,
            COUNTER_PICK
        }

        public enum GameQueueType
        {
            RANKED_SOLO_5x5,
            RANKED_TEAM_3x3,
            RANKED_TEAM_5x5,
            TEAM_BUILDER_DRAFT_RANKED_5x5
        }

        public enum QueueType
        {
            CUSTOM,
            NORMAL_5x5_BLIND,
            RANKED_SOLO_5x5,
            RANKED_PREMADE_5x5,
            BOT_5x5,
            NORMAL_3x3,
            RANKED_PREMADE_3x3,
            NORMAL_5x5_DRAFT,
            ODIN_5x5_BLIND,
            ODIN_5x5_DRAFT,
            BOT_ODIN_5x5,
            BOT_5x5_INTRO,
            BOT_5x5_BEGINNER,
            BOT_5x5_INTERMEDIATE,
            RANKED_TEAM_3x3,
            RANKED_TEAM_5x5,
            BOT_TT_3x3,
            GROUP_FINDER_5x5, ARAM_5x5,
            ONEFORALL_5x5,
            FIRSTBLOOD_1x1,
            FIRSTBLOOD_2x2,
            SR_6x6, URF_5x5,
            ONEFORALL_MIRRORMODE_5x5,
            BOT_URF_5x5,
            NIGHTMARE_BOT_5x5_RANK1,
            NIGHTMARE_BOT_5x5_RANK2,
            NIGHTMARE_BOT_5x5_RANK5,
            ASCENSION_5x5,
            HEXAKILL,
            KING_PORO_5x5,
            COUNTER_PICK,
            BILGEWATER_ARAM_5x5,
            BILGEWATER_5x5,
            TEAM_BUILDER_DRAFT_UNRANKED_5X5,
            TEAM_BUILDER_DRAFT_RANKED_5X5
        }

        public enum Tier
        {
            CHALLENGER,
            MASTER,
            DIAMOND,
            PLATINUM, //I WISH!!!
            GOLD,
            SILVER,
            BRONZE
        }

        public enum MasteryTree
        {
            Cunning,
            Ferocity,
            Resolve
        }

        public enum AscendedType
        {
            CHAMPION_ASCENDED,
            CLEAR_ASCENDED,
            MINION_ASCENDED
        }

        public enum BuildingType
        {
            INHIBITOR_BUILDING,
            TOWER_BUILDING
        }

        public enum EventType
        {
            ASCENDED_EVENT,
            BUILDING_KILL,
            CAPTURE_POINT,
            CHAMPION_KILL,
            ELITE_MONSTER_KILL,
            ITEM_DESTROYED,
            ITEM_PURCHASED,
            ITEM_SOLD,
            ITEM_UNDO,
            PORO_KING_SUMMON,
            SKILL_LEVEL_UP,
            WARD_KILL,
            WARD_PLACED
        }

        public enum LaneType
        {
            BOT_LANE,
            MID_LANE,
            TOP_LANE
        }

        public enum LevelUpType
        {
            EVOLVE,
            NORMAL
        }

        public enum MonsterType
        {
            BARON_NASHOR,
            BLUE_GOLEM,
            DRAGON,
            RED_LIZARD,
            RIFTHERALD,
            VILEMAW
        }

        public enum PointCaptured
        {
            POINT_A,
            POINT_B,
            POINT_C,
            POINT_D,
            POINT_E
        }

        public enum TowerType
        {
            BASE_TURRET,
            FOUNTAIN_TURRET,
            INNER_TURRET,
            NEXUS_TURRET,
            OUTER_TURRET,
            UNDEFINED_TURRET
        }

        public enum WardType
        {
            BLUE_TRINKET,
            SIGHT_WARD,
            TEEMO_MUSHROOM,
            UNDEFINED,
            VISION_WARD,
            YELLOW_TRINKET,
            YELLOW_TRINKET_UPGRADE
        }

        public enum Lane
        {
            MID,
            MIDDLE,
            TOP,
            JUNGLE,
            BOT,
            BOTTOM
        }

        public enum Role
        {
            DUO,
            NONE,
            SOLO,
            DUO_CARRY,
            DUO_SUPPORT
        }

        public enum HighestAchievedSeasonTier
        {
            CHALLENGER,
            MASTER,
            DIAMOND,
            PLATINUM,
            GOLD,
            SILVER,
            BRONZE,
            UNRANKED
        }

        public enum PlayerStatSummaryType
        {
            AramUnranked5x5,
            Ascension,
            CAP5x5,
            CoopVsAI,
            CoopVsAI3x3,
            CounterPick,
            FirstBlood1x1,
            FirstBlood2x2,
            Hexakill,
            KingPoro,
            NightmareBot,
            OdinUnranked,
            OneForAll5x5,
            RankedPremade3x3,
            RankedPremade5x5,
            RankedSolo5x5,
            RankedTeam3x3,
            RankedTeam5x5,
            SummonersRift6x6,
            Unranked,
            Unranked3x3,
            URF,
            URFBots,
            Bilgewater
        }

        public enum MessageSeverity
        {
            Info,
            Alert,
            Error
        }

        public enum ServiceStatus
        {
            Online,
            Alert,
            Offline,
            Deploying
        }
    }
}

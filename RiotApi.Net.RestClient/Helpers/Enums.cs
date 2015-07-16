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

        public enum QueueType
        {
            RANKED_SOLO_5x5,
            RANKED_TEAM_3x3,
            RANKED_TEAM_5x5
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
            Defense,
            Offense,
            Utility
        }

        public enum RegionalEndPoints
        {
            BR,
            EUNE,
            EUW,
            KR,
            LAN,
            LAS,
            NA,
            OCE,
            TR,
            RU,
            PBE,
            Global
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
            WARD_PLACED,
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
    }
}

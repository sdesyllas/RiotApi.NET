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
    }
}

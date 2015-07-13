using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.CurrentGame
{
    /// <summary>
    /// Current Game Info
    /// </summary>
    public class CurrentGameInfo : RiotDto
    {
        /// <summary>
        /// List[BannedChampion]	Banned champion information
        /// </summary>
        [JsonProperty(PropertyName = "bannedChampions")]
        public IEnumerable<BannedChampion> BannedChampions { get; set; }

        /// <summary>
        /// The ID of the game
        /// </summary>
        [JsonProperty(PropertyName = "gameId")]
        public long GameId { get; set; }

        /// <summary>
        /// The amount of time in seconds that has passed since the game started
        /// </summary>
        [JsonProperty(PropertyName = "gameLength")]
        public long GameLength { get; set; }

        /// <summary>
        /// The game mode (Legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
        /// </summary>
        [JsonProperty(PropertyName = "gameMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.GameMode GameMode { get; set; }

        /// <summary>
        /// The queue type (queue types are documented on the Game Constants page)
        /// </summary>
        [JsonProperty(PropertyName = "gameQueueConfigId")]
        public long GameQueueConfigId { get; set; }

        /// <summary>
        /// The game start time represented in epoch milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "gameStartTime")]
        public long GameStartTime { get; set; }

        /// <summary>
        /// The game type (Legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
        /// </summary>
        [JsonProperty(PropertyName = "gameType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.GameType GameType { get; set; }

        /// <summary>
        /// The ID of the map
        /// </summary>
        [JsonProperty(PropertyName = "mapId")]
        public long MapId { get; set; }

        /// <summary>
        /// The observer information
        /// </summary>
        [JsonProperty(PropertyName = "observers")]
        public Observer Observers { get; set; }

        /// <summary>
        /// List[CurrentGameParticipant] The participant information
        /// </summary>
        [JsonProperty(PropertyName = "participants")]
        public IEnumerable<CurrentGameParticipant> Participants { get; set; }

        /// <summary>
        /// The ID of the platform on which the game is being played
        /// </summary>
        [JsonProperty(PropertyName = "platformId")]
        public string PlatformId { get; set; }

        /// <summary>
        /// Banned Champion
        /// </summary>
        public class BannedChampion
        {
            /// <summary>
            /// The ID of the banned champion
            /// </summary>
            [JsonProperty(PropertyName = "championId")]
            public long ChampionId { get; set; }

            /// <summary>
            /// The turn during which the champion was banned
            /// </summary>
            [JsonProperty(PropertyName = "pickTurn")]
            public int PickTurn { get; set; }

            /// <summary>
            /// The ID of the team that banned the champion
            /// </summary>
            [JsonProperty(PropertyName = "teamId")]
            public long TeamId { get; set; }
        }

        /// <summary>
        /// Current Game Participant
        /// </summary>
        public class CurrentGameParticipant
        {
            /// <summary>
            /// Flag indicating whether or not this participant is a bot
            /// </summary>
            [JsonProperty(PropertyName = "bot")]
            public bool Bot { get; set; }

            /// <summary>
            /// The ID of the champion played by this participant
            /// </summary>
            [JsonProperty(PropertyName = "championId")]
            public long ChampionId { get; set; }

            /// <summary>
            /// The masteries used by this participant
            /// </summary>
            [JsonProperty(PropertyName = "masteries")]
            public IEnumerable<Mastery> Masteries { get; set; }

            /// <summary>
            /// The ID of the profile icon used by this participant
            /// </summary>
            [JsonProperty(PropertyName = "profileIconId")]
            public long ProfileIconId { get; set; }

            /// <summary>
            /// List[Rune]	The runes used by this participant
            /// </summary>
            [JsonProperty(PropertyName = "runes")]
            public IEnumerable<Rune> Runes { get; set; }

            /// <summary>
            /// The ID of the first summoner spell used by this participant
            /// </summary>
            [JsonProperty(PropertyName = "spell1Id")]
            public long Spell1Id { get; set; }

            /// <summary>
            /// The ID of the second summoner spell used by this participant
            /// </summary>
            [JsonProperty(PropertyName = "spell2Id")]
            public long Spell2Id { get; set; }

            /// <summary>
            /// The summoner ID of this participant
            /// </summary>
            [JsonProperty(PropertyName = "summonerId")]
            public long SummonerId { get; set; }

            /// <summary>
            /// The summoner name of this participant
            /// </summary>
            [JsonProperty(PropertyName = "summonerName")]
            public string SummonerName { get; set; }

            /// <summary>
            /// The team ID of this participant, indicating the participant's team
            /// </summary>
            [JsonProperty(PropertyName = "teamId")]
            public long TeamId { get; set; }
        }

        /// <summary>
        /// Observer
        /// </summary>
        public class Observer
        {
            /// <summary>
            /// Key used to decrypt the spectator grid game data for playback
            /// </summary>
            [JsonProperty(PropertyName = "encryptionKey")]
            public string EncryptionKey { get; set; }
        }

        /// <summary>
        /// Mastery
        /// </summary>
        public class Mastery
        {
            /// <summary>
            /// The ID of the mastery
            /// </summary>
            [JsonProperty(PropertyName = "masteryId")]
            public long MasteryId { get; set; }

            /// <summary>
            /// The number of points put into this mastery by the user
            /// </summary>
            [JsonProperty(PropertyName = "rank")]
            public int Rank { get; set; }
        }

        /// <summary>
        /// Rune
        /// </summary>
        public class Rune
        {
            /// <summary>
            /// The count of this rune used by the participant
            /// </summary>
            [JsonProperty(PropertyName = "count")]
            public int Count { get; set; }

            /// <summary>
            /// The ID of the rune
            /// </summary>
            [JsonProperty(PropertyName = "runeId")]
            public long RuneId { get; set; }
        }
    }
}

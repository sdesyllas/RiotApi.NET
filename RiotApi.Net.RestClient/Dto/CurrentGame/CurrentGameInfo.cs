using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.CurrentGame
{
    /// <summary>
    /// Current Game Info
    /// </summary>
    [DataContract]
    public class CurrentGameInfo : RiotDto
    {
        /// <summary>
        /// List[BannedChampion]	Banned champion information
        /// </summary>
        [DataMember(Name = "bannedChampions")]
        public IEnumerable<BannedChampion> BannedChampions { get; set; }

        /// <summary>
        /// The ID of the game
        /// </summary>
        [DataMember(Name = "gameId")]
        public long GameId { get; set; }

        /// <summary>
        /// The amount of time in seconds that has passed since the game started
        /// </summary>
        [DataMember(Name = "gameLength")]
        public long GameLength { get; set; }

        /// <summary>
        /// The game mode (Legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
        /// </summary>
        [DataMember(Name = "gameMode")]
        public Helpers.Enums.GameMode GameMode { get; set; }

        /// <summary>
        /// The queue type (queue types are documented on the Game Constants page)
        /// </summary>
        [DataMember(Name = "gameQueueConfigId")]
        public long GameQueueConfigId { get; set; }

        /// <summary>
        /// The game start time represented in epoch milliseconds
        /// </summary>
        [DataMember(Name = "gameStartTime")]
        public long GameStartTime { get; set; }

        /// <summary>
        /// The game type (Legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
        /// </summary>
        [DataMember(Name = "gameType")]
        public Helpers.Enums.GameType GameType { get; set; }

        /// <summary>
        /// The ID of the map
        /// </summary>
        [DataMember(Name = "mapId")]
        public long MapId { get; set; }

        /// <summary>
        /// The observer information
        /// </summary>
        [DataMember(Name = "observers")]
        public Observer Observers { get; set; }

        /// <summary>
        /// List[CurrentGameParticipant] The participant information
        /// </summary>
        [DataMember(Name = "participants")]
        public IEnumerable<CurrentGameParticipant> Participants { get; set; }

        /// <summary>
        /// The ID of the platform on which the game is being played
        /// </summary>
        [DataMember(Name = "platformId")]
        public string PlatformId { get; set; }

        /// <summary>
        /// Banned Champion
        /// </summary>
        [DataContract]
        public class BannedChampion
        {
            /// <summary>
            /// The ID of the banned champion
            /// </summary>
            [DataMember(Name = "championId")]
            public long ChampionId { get; set; }

            /// <summary>
            /// The turn during which the champion was banned
            /// </summary>
            [DataMember(Name = "pickTurn")]
            public int PickTurn { get; set; }

            /// <summary>
            /// The ID of the team that banned the champion
            /// </summary>
            [DataMember(Name = "teamId")]
            public long TeamId { get; set; }
        }

        /// <summary>
        /// Current Game Participant
        /// </summary>
        [DataContract]
        public class CurrentGameParticipant
        {
            /// <summary>
            /// Flag indicating whether or not this participant is a bot
            /// </summary>
            [DataMember(Name = "bot")]
            public bool Bot { get; set; }

            /// <summary>
            /// The ID of the champion played by this participant
            /// </summary>
            [DataMember(Name = "championId")]
            public long ChampionId { get; set; }

            /// <summary>
            /// The masteries used by this participant
            /// </summary>
            [DataMember(Name = "masteries")]
            public IEnumerable<Mastery> Masteries { get; set; }

            /// <summary>
            /// The ID of the profile icon used by this participant
            /// </summary>
            [DataMember(Name = "profileIconId")]
            public long ProfileIconId { get; set; }

            /// <summary>
            /// List[Rune]	The runes used by this participant
            /// </summary>
            [DataMember(Name = "runes")]
            public IEnumerable<Rune> Runes { get; set; }

            /// <summary>
            /// The ID of the first summoner spell used by this participant
            /// </summary>
            [DataMember(Name = "spell1Id")]
            public long Spell1Id { get; set; }

            /// <summary>
            /// The ID of the second summoner spell used by this participant
            /// </summary>
            [DataMember(Name = "spell2Id")]
            public long Spell2Id { get; set; }

            /// <summary>
            /// The summoner ID of this participant
            /// </summary>
            [DataMember(Name = "summonerId")]
            public long SummonerId { get; set; }

            /// <summary>
            /// The summoner name of this participant
            /// </summary>
            [DataMember(Name = "summonerName")]
            public string SummonerName { get; set; }

            /// <summary>
            /// The team ID of this participant, indicating the participant's team
            /// </summary>
            [DataMember(Name = "teamId")]
            public long TeamId { get; set; }
        }

        /// <summary>
        /// Observer
        /// </summary>
        [DataContract]
        public class Observer
        {
            /// <summary>
            /// Key used to decrypt the spectator grid game data for playback
            /// </summary>
            [DataMember(Name = "encryptionKey")]
            public string EncryptionKey { get; set; }
        }

        /// <summary>
        /// Mastery
        /// </summary>
        [DataContract]
        public class Mastery
        {
            /// <summary>
            /// The ID of the mastery
            /// </summary>
            [DataMember(Name = "masteryId")]
            public long MasteryId { get; set; }

            /// <summary>
            /// The number of points put into this mastery by the user
            /// </summary>
            [DataMember(Name = "rank")]
            public int Rank { get; set; }
        }

        /// <summary>
        /// Rune
        /// </summary>
        [DataContract]
        public class Rune
        {
            /// <summary>
            /// The count of this rune used by the participant
            /// </summary>
            [DataMember(Name = "count")]
            public int Count { get; set; }

            /// <summary>
            /// The ID of the rune
            /// </summary>
            [DataMember(Name = "runeId")]
            public long RuneId { get; set; }
        }
    }
}

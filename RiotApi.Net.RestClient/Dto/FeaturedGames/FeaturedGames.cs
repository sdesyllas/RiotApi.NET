using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.FeaturedGames
{
    /// <summary>
    /// FeaturedGames
    /// </summary>
    [DataContract]
    public class FeaturedGames : RiotDto
    {
        /// <summary>
        /// ClientRefreshInterval  The suggested interval to wait before requesting FeaturedGames again
        /// </summary>
        [DataMember(Name = "clientRefreshInterval")]
        public long ClientRefreshInterval { get; set; }

        /// <summary>
        /// The list of featured games
        /// </summary>
        [DataMember(Name = "gameList")]
        public IEnumerable<FeaturedGameInfo> GameList { get; set; }

        [DataContract]
        public class FeaturedGameInfo : RiotDto
        {
            /// <summary>
            /// Banned champion information
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
            /// The participant information
            /// </summary>
            [DataMember(Name = "participants")]
            public IEnumerable<Participant> Participants { get; set; }

            /// <summary>
            /// The ID of the platform on which the game is being played
            /// </summary>
            [DataMember(Name = "platformId")]
            public string PlatformId { get; set; }
        }


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

        [DataContract]
        public class Observer
        {
            /// <summary>
            /// Key used to decrypt the spectator grid game data for playback
            /// </summary>
            [DataMember(Name = "encryptionKey")]
            public string EncryptionKey { get; set; }
        }

        [DataContract]
        public class Participant
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
            /// The ID of the profile icon used by this participant
            /// </summary>
            [DataMember(Name = "profileIconId")]
            public long ProfileIconId { get; set; }

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
    }
}

using RiotApi.Net.RestClient.Dto.Match.Generic;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.MatchHistory
{
    /// <summary>
    /// This object contains player match history information
    /// </summary>
    [DataContract]
    public class PlayerHistory : RiotDto
    {
        /// <summary>
        /// List of matches for the player
        /// </summary>
        [DataMember(Name = "matches")]
        public IEnumerable<MatchSummary> Matches { get; set; }

        /// <summary>
        /// This object contains match summary information
        /// </summary>
        [DataContract]
        public class MatchSummary
        {
            /// <summary>
            /// Match map ID
            /// </summary>
            [DataMember(Name = "mapId")]
            public int MapId { get; set; }

            /// <summary>
            /// Match creation time. Designates when the team select lobby is created and/or the match is made through match making, 
            /// not when the game actually starts.
            /// </summary>
            [DataMember(Name = "matchCreation")]
            public long MatchCreation { get; set; }

            /// <summary>
            /// Match duration
            /// </summary>
            [DataMember(Name = "matchDuration")]
            public long MatchDuration { get; set; }

            /// <summary>
            /// ID of the match
            /// </summary>
            [DataMember(Name = "matchId")]
            public long MatchId { get; set; }

            /// <summary>
            /// Match mode (Legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
            /// </summary>
            [DataMember(Name = "matchMode")]
            public Helpers.Enums.GameMode MatchMode { get; set; }

            /// <summary>
            /// Match type (Legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
            /// </summary>
            [DataMember(Name = "matchType")]
            public Helpers.Enums.GameType MatchType { get; set; }

            /// <summary>
            /// Match version
            /// </summary>
            [DataMember(Name = "matchVersion")]
            public string MatchVersion { get; set; }

            /// <summary>
            /// Participant identity information
            /// </summary>
            [DataMember(Name = "participantIdentities")]
            public IEnumerable<ParticipantIdentity> ParticipantIdentities { get; set; }

            /// <summary>
            /// Participant information
            /// </summary>
            [DataMember(Name = "participants")]
            public IEnumerable<Participant> Participants { get; set; }

            /// <summary>
            /// Platform ID of the match
            /// </summary>
            [DataMember(Name = "platformId")]
            public string PlatformId { get; set; }

            /// <summary>
            /// Match queue type (Legal values: CUSTOM, NORMAL_5x5_BLIND, RANKED_SOLO_5x5, RANKED_PREMADE_5x5, BOT_5x5, NORMAL_3x3, 
            /// RANKED_PREMADE_3x3, NORMAL_5x5_DRAFT, ODIN_5x5_BLIND, ODIN_5x5_DRAFT, BOT_ODIN_5x5, BOT_5x5_INTRO, BOT_5x5_BEGINNER, 
            /// BOT_5x5_INTERMEDIATE, RANKED_TEAM_3x3, RANKED_TEAM_5x5, BOT_TT_3x3, GROUP_FINDER_5x5, ARAM_5x5, ONEFORALL_5x5, 
            /// FIRSTBLOOD_1x1, FIRSTBLOOD_2x2, SR_6x6, URF_5x5, ONEFORALL_MIRRORMODE_5x5, BOT_URF_5x5, NIGHTMARE_BOT_5x5_RANK1, 
            /// NIGHTMARE_BOT_5x5_RANK2, NIGHTMARE_BOT_5x5_RANK5, ASCENSION_5x5, HEXAKILL, KING_PORO_5x5, COUNTER_PICK)
            /// </summary>
            [DataMember(Name = "queueType")]
            public Helpers.Enums.QueueType QueueType { get; set; }

            /// <summary>
            /// Region where the match was played
            /// </summary>
            [DataMember(Name = "region")]
            public string Region { get; set; }

            /// <summary>
            /// Season match was played (Legal values: PRESEASON3, SEASON3, PRESEASON2014, SEASON2014, PRESEASON2015, SEASON2015)
            /// </summary>
            [DataMember(Name = "season")]
            public string Season { get; set; }
        }
    }
}

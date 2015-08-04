using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RiotApi.Net.RestClient.Dto.Match.Generic;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Match
{
    /// <summary>
    /// This object contains match detail information
    /// </summary>
    public class MatchDetail : RiotDto
    {
        /// <summary>
        /// Match map ID
        /// </summary>
        [JsonProperty(PropertyName = "mapId")]
        public int MapId { get; set; }

        /// <summary>
        /// Match creation time. Designates when the team select lobby is created and/or the match is made through match making, 
        /// not when the game actually starts.
        /// </summary>
        [JsonProperty(PropertyName = "matchCreation")]
        public long MatchCreation { get; set; }

        /// <summary>
        /// Match duration
        /// </summary>
        [JsonProperty(PropertyName = "matchDuration")]
        public long MatchDuration { get; set; }

        /// <summary>
        /// ID of the match
        /// </summary>
        [JsonProperty(PropertyName = "matchId")]
        public long MatchId { get; set; }

        /// <summary>
        /// Match mode (Legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, ASCENSION, FIRSTBLOOD, KINGPORO)
        /// </summary>
        [JsonProperty(PropertyName = "matchMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.GameMode MatchMode { get; set; }

        /// <summary>
        /// Match type (Legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)
        /// </summary>
        [JsonProperty(PropertyName = "matchType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.GameType MatchType { get; set; }

        /// <summary>
        /// Match version
        /// </summary>
        [JsonProperty(PropertyName = "matchVersion")]
        public string MatchVersion { get; set; }

        /// <summary>
        /// Participant identity information
        /// </summary>
        [JsonProperty(PropertyName = "participantIdentities")]
        public IEnumerable<ParticipantIdentity> ParticipantIdentities { get; set; }

        /// <summary>
        /// Participant information
        /// </summary>
        [JsonProperty(PropertyName = "participants")]
        public IEnumerable<Participant> Participants { get; set; }

        /// <summary>
        /// Platform ID of the match
        /// </summary>
        [JsonProperty(PropertyName = "platformId")]
        public string PlatformId { get; set; }

        /// <summary>
        /// Match queue type (Legal values: CUSTOM, NORMAL_5x5_BLIND, RANKED_SOLO_5x5, RANKED_PREMADE_5x5, BOT_5x5, NORMAL_3x3, 
        /// RANKED_PREMADE_3x3, NORMAL_5x5_DRAFT, ODIN_5x5_BLIND, ODIN_5x5_DRAFT, BOT_ODIN_5x5, BOT_5x5_INTRO, BOT_5x5_BEGINNER, 
        /// BOT_5x5_INTERMEDIATE, RANKED_TEAM_3x3, RANKED_TEAM_5x5, BOT_TT_3x3, GROUP_FINDER_5x5, ARAM_5x5, ONEFORALL_5x5, 
        /// FIRSTBLOOD_1x1, FIRSTBLOOD_2x2, SR_6x6, URF_5x5, ONEFORALL_MIRRORMODE_5x5, BOT_URF_5x5, NIGHTMARE_BOT_5x5_RANK1, 
        /// NIGHTMARE_BOT_5x5_RANK2, NIGHTMARE_BOT_5x5_RANK5, ASCENSION_5x5, HEXAKILL, KING_PORO_5x5, COUNTER_PICK,  BILGEWATER_ARAM_5x5
        /// BILGEWATER_5x5)
        /// </summary>
        [JsonProperty(PropertyName = "queueType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.QueueType QueueType { get; set; }

        /// <summary>
        /// Region where the match was played
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Season match was played (Legal values: PRESEASON3, SEASON3, PRESEASON2014, SEASON2014, PRESEASON2015, SEASON2015)
        /// </summary>
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        /// <summary>
        /// Team information
        /// </summary>
        [JsonProperty(PropertyName = "teams")]
        public IEnumerable<TeamDto> Teams { get; set; }

        /// <summary>
        /// Match timeline data (not included by default)
        /// </summary>
        [JsonProperty(PropertyName = "timeline")]
        public Timeline Timeline { get; set; }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.League
{
    public class LeagueDto
    {
        /// <summary>
        /// The requested league entries.
        /// </summary>
        [JsonProperty(PropertyName = "entries")]
        public IEnumerable<LeagueEntryDto> Entries { get; set; }

        /// <summary>
        /// This name is an internal place-holder name only. Display and localization of names in the game client are handled client-side.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the relevant participant that is a member of this league (i.e., a requested summoner ID, a requested team ID, or the ID of a team to which one of the requested summoners belongs). Only present when full league is requested so that participant's entry can be identified. Not present when individual entry is requested.
        /// </summary>
        [JsonProperty(PropertyName = "participantId")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// The league's queue type. (Legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)
        /// </summary>
        [JsonProperty(PropertyName = "queue")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.QueueType Queue { get; set; }

        /// <summary>
        /// The league's tier. (Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE)
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.Tier Tier { get; set; }

        /// <summary>
        /// This object contains league participant information representing a summoner or team.
        /// </summary>
        public class LeagueEntryDto
        {
            /// <summary>
            /// The league division of the participant.
            /// </summary>
            [JsonProperty(PropertyName = "division")]
            public string Division { get; set; }

            /// <summary>
            /// Specifies if the participant is fresh blood.
            /// </summary>
            [JsonProperty(PropertyName = "isFreshBlood")]
            public bool IsFreshBlood { get; set; }

            /// <summary>
            /// Specifies if the participant is on a hot streak.
            /// </summary>
            [JsonProperty(PropertyName = "isHotStreak")]
            public bool IsHotStreak { get; set; }

            /// <summary>
            /// Specifies if the participant is on a hot streak.
            /// </summary>
            [JsonProperty(PropertyName = "isInactive")]
            public bool IsInactive { get; set; }

            /// <summary>
            /// Specifies if the participant is a veteran.
            /// </summary>
            [JsonProperty(PropertyName = "isVeteran")]
            public bool IsVeteran { get; set; }

            /// <summary>
            /// The league points of the participant.
            /// </summary>
            [JsonProperty(PropertyName = "leaguePoints")]
            public int LeaguePoints { get; set; }

            /// <summary>
            /// The number of losses for the participant.
            /// </summary>
            [JsonProperty(PropertyName = "losses")]
            public int Losses { get; set; }

            /// <summary>
            /// Mini series data for the participant. Only present if the participant is currently in a mini series.
            /// </summary>
            [JsonProperty(PropertyName = "miniSeries")]
            public MiniSeriesDto MiniSeries { get; set; }

            /// <summary>
            /// The ID of the participant (i.e., summoner or team) represented by this entry.
            /// </summary>
            [JsonProperty(PropertyName = "playerOrTeamId")]
            public string PlayerOrTeamId { get; set; }

            /// <summary>
            /// The name of the the participant (i.e., summoner or team) represented by this entry.
            /// </summary>
            [JsonProperty(PropertyName = "playerOrTeamName")]
            public string PlayerOrTeamName { get; set; }

            /// <summary>
            /// The number of wins for the participant.
            /// </summary>
            [JsonProperty(PropertyName = "wins")]
            public int Wins { get; set; }

            /// <summary>
            /// This object contains mini series information.
            /// </summary>
            public class MiniSeriesDto
            {
                /// <summary>
                /// Number of current losses in the mini series.
                /// </summary>
                [JsonProperty(PropertyName = "losses")]
                public int Losses { get; set; }

                /// <summary>
                /// String showing the current, sequential mini series progress where 'W' represents a win, 'L' represents a loss, and 'N' represents a game that hasn't been played yet.
                /// </summary>
                [JsonProperty(PropertyName = "progress")]
                public string Progress { get; set; }

                /// <summary>
                /// Number of wins required for promotion.
                /// </summary>
                [JsonProperty(PropertyName = "target")]
                public int Target { get; set; }

                /// <summary>
                /// Number of current wins in the mini series.
                /// </summary>
                [JsonProperty(PropertyName = "wins")]
                public int Wins { get; set; }
            }
        }
    }
}

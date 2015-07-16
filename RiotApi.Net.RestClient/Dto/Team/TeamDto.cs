using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Team
{
    /// <summary>
    /// This object contains team information.
    /// </summary>
    public class TeamDto : RiotDto
    {
        /// <summary>
        /// Date that team was created specified as epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "createDate")]
        public long CreateDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "fullId")]
        public string fullId { get; set; }

        /// <summary>
        ///	Date that last game played by team ended specified as epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "lastGameDate")]
        public long LastGameDate { get; set; }

        /// <summary>
        ///	Date that last member joined specified as epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "lastJoinDate")]
        public long LastJoinDate { get; set; }

        /// <summary>
        ///	Date that team last joined the ranked team queue specified as epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "lastJoinedRankedTeamQueueDate")]
        public long LastJoinedRankedTeamQueueDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "matchHistory")]
        public IEnumerable<MatchHistorySummaryDto> MatchHistory { get; set; }

        /// <summary>
        /// Date that team was last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "modifyDate")]
        public long ModifyDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "roster")]
        public RosterDto Roster { get; set; }

        /// <summary>
        ///	Date that second to last member joined specified as epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "secondLastJoinDate")]
        public long SecondLastJoinDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "teamStatDetails")]
        public IEnumerable<TeamStatDetailDto> TeamStatDetails { get; set; }

        /// <summary>
        /// Date that third to last member joined specified as epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "thirdLastJoinDate")]
        public long ThirdLastJoinDate { get; set; }

        /// <summary>
        /// This object contains match history summary information.
        /// </summary>
        public class MatchHistorySummaryDto
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "assists")]
            public int Assists { get; set; }

            /// <summary>
            /// Date that match was completed specified as epoch milliseconds.
            /// </summary>
            [JsonProperty(PropertyName = "date")]
            public long Date { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "deaths")]
            public int Deaths { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "gameId")]
            public long GameId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "gameMode")]
            public string GameMode { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "invalid")]
            public bool Invalid { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "kills")]
            public int Kills { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "mapId")]
            public int MapId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "opposingTeamKills")]
            public int OpposingTeamKills { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "opposingTeamName")]
            public string OpposingTeamName { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "win")]
            public bool Win { get; set; }
        }

        /// <summary>
        /// This object contains roster information.
        /// </summary>
        public class RosterDto
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "memberList")]
            public IEnumerable<TeamMemberInfoDto> MemberList { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "ownerId")]
            public long OwnerId { get; set; }
        }

        /// <summary>
        /// This object contains team statistics detail information.
        /// </summary>
        public class TeamStatDetailDto
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "averageGamesPlayed")]
            public int AverageGamesPlayed { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "losses")]
            public int Losses { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "teamStatType")]
            public string TeamStatType { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "wins")]
            public int Wins { get; set; }
        }

        /// <summary>
        /// This object contains team member information.
        /// </summary>
        public class TeamMemberInfoDto
        {
            /// <summary>
            /// Date that team member was invited to team specified as epoch milliseconds.
            /// </summary>
            [JsonProperty(PropertyName = "inviteDate")]
            public long InviteDate { get; set; }

            /// <summary>
            /// Date that team member joined team specified as epoch milliseconds.
            /// </summary>
            [JsonProperty(PropertyName = "joinDate")]
            public long JoinDate { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "playerId")]
            public long PlayerId { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "status")]
            public string Status { get; set; }
        }
    }
}

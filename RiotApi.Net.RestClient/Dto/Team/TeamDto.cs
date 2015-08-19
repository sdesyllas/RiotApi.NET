using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Team
{
    /// <summary>
    /// This object contains team information.
    /// </summary>
    [DataContract]
    public class TeamDto : RiotDto
    {
        /// <summary>
        /// Date that team was created specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "createDate")]
        public long CreateDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "fullId")]
        public string FullId { get; set; }

        /// <summary>
        ///	Date that last game played by team ended specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "lastGameDate")]
        public long LastGameDate { get; set; }

        /// <summary>
        ///	Date that last member joined specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "lastJoinDate")]
        public long LastJoinDate { get; set; }

        /// <summary>
        ///	Date that team last joined the ranked team queue specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "lastJoinedRankedTeamQueueDate")]
        public long LastJoinedRankedTeamQueueDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "matchHistory")]
        public IEnumerable<MatchHistorySummaryDto> MatchHistory { get; set; }

        /// <summary>
        /// Date that team was last modified specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "modifyDate")]
        public long ModifyDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "roster")]
        public RosterDto Roster { get; set; }

        /// <summary>
        ///	Date that second to last member joined specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "secondLastJoinDate")]
        public long SecondLastJoinDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "tag")]
        public string Tag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "teamStatDetails")]
        public IEnumerable<TeamStatDetailDto> TeamStatDetails { get; set; }

        /// <summary>
        /// Date that third to last member joined specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "thirdLastJoinDate")]
        public long ThirdLastJoinDate { get; set; }

        /// <summary>
        /// This object contains match history summary information.
        /// </summary>
        [DataContract]
        public class MatchHistorySummaryDto
        {
            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "assists")]
            public int Assists { get; set; }

            /// <summary>
            /// Date that match was completed specified as epoch milliseconds.
            /// </summary>
            [DataMember(Name = "date")]
            public long Date { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "deaths")]
            public int Deaths { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "gameId")]
            public long GameId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "gameMode")]
            public string GameMode { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "invalid")]
            public bool Invalid { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "kills")]
            public int Kills { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "mapId")]
            public int MapId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "opposingTeamKills")]
            public int OpposingTeamKills { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "opposingTeamName")]
            public string OpposingTeamName { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "win")]
            public bool Win { get; set; }
        }

        /// <summary>
        /// This object contains roster information.
        /// </summary>
        [DataContract]
        public class RosterDto
        {
            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "memberList")]
            public IEnumerable<TeamMemberInfoDto> MemberList { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "ownerId")]
            public long OwnerId { get; set; }
        }

        /// <summary>
        /// This object contains team statistics detail information.
        /// </summary>
        [DataContract]
        public class TeamStatDetailDto
        {
            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "averageGamesPlayed")]
            public int AverageGamesPlayed { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "losses")]
            public int Losses { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "teamStatType")]
            public string TeamStatType { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "wins")]
            public int Wins { get; set; }
        }

        /// <summary>
        /// This object contains team member information.
        /// </summary>
        [DataContract]
        public class TeamMemberInfoDto
        {
            /// <summary>
            /// Date that team member was invited to team specified as epoch milliseconds.
            /// </summary>
            [DataMember(Name = "inviteDate")]
            public long InviteDate { get; set; }

            /// <summary>
            /// Date that team member joined team specified as epoch milliseconds.
            /// </summary>
            [DataMember(Name = "joinDate")]
            public long JoinDate { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "playerId")]
            public long PlayerId { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "status")]
            public string Status { get; set; }
        }
    }
}

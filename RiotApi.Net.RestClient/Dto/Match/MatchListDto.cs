using System.Collections.Generic;
using System.Runtime.Serialization;
using RiotApi.Net.RestClient.Dto.Match.Generic;

namespace RiotApi.Net.RestClient.Dto.Match
{
    /// <summary>
    /// MatchList - This object contains match list information
    /// </summary>
    [DataContract]
    public class MatchListDto : RiotDto
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "endIndex")]
        public int EndIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "matches")]
        public List<MatchReference> Matches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "startIndex")]
        public int StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "totalGames")]
        public int TotalGames { get; set; }

        /// <summary>
        /// MatchReference - This object contains match reference information
        /// </summary>
        [DataContract]
        public class MatchReference
        {
            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "champion")]
            public long Champion { get; set; }

            /// <summary>
            /// Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM
            /// </summary>
            [DataMember(Name = "lane")]
            public Helpers.Enums.Lane Lane { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "matchId")]
            public long MatchId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "platformId")]
            public string PlatformId { get; set; }

            /// <summary>
            /// Legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5
            /// </summary>
            [DataMember(Name = "queue")]
            public Helpers.Enums.GameQueueType Queue { get; set; }

            /// <summary>
            /// Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT
            /// </summary>
            [DataMember(Name = "role")]
            public Helpers.Enums.Role Role { get; set; }

            /// <summary>
            /// Legal values: PRESEASON3, SEASON3, PRESEASON2014, SEASON2014, PRESEASON2015, SEASON2015
            /// </summary>
            [DataMember(Name = "season")]
            public string Season { get; set; }
        }
    }
}
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RiotApi.Net.RestClient.Dto.Match.Generic;

namespace RiotApi.Net.RestClient.Dto.Match
{
    /// <summary>
    /// MatchList - This object contains match list information
    /// </summary>
    public class MatchListDto : RiotDto
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "endIndex")]
        public int EndIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "matches")]
        public List<MatchReference> Matches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "startIndex")]
        public int StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "totalGames")]
        public int TotalGames { get; set; }

        /// <summary>
        /// MatchReference - This object contains match reference information
        /// </summary>
        public class MatchReference
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "champion")]
            public long Champion { get; set; }

            /// <summary>
            /// Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM
            /// </summary>
            [JsonProperty(PropertyName = "lane")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Helpers.Enums.Lane Lane { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "matchId")]
            public long MatchId { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "platformId")]
            public string PlatformId { get; set; }

            /// <summary>
            /// Legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5
            /// </summary>
            [JsonProperty(PropertyName = "queue")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Helpers.Enums.GameQueueType Queue { get; set; }

            /// <summary>
            /// Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT
            /// </summary>
            [JsonProperty(PropertyName = "role")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Helpers.Enums.Role Role { get; set; }

            /// <summary>
            /// Legal values: PRESEASON3, SEASON3, PRESEASON2014, SEASON2014, PRESEASON2015, SEASON2015
            /// </summary>
            [JsonProperty(PropertyName = "season")]
            public string Season { get; set; }
        }
    }
}
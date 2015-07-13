using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Mastery
{
    /// <summary>
    /// This object contains mastery tree data.
    /// </summary>
    public class MasteryTreeDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "Defense")]
        public IEnumerable<MasteryTreeListDto> Defense { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "Offense")]
        public IEnumerable<MasteryTreeListDto> Offense { get; set; }

                /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "Utility")]
        public IEnumerable<MasteryTreeListDto> Utility { get; set; }

        public class MasteryTreeListDto
        {
            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [JsonProperty(PropertyName = "masteryTreeItems")]
            public IEnumerable<MasteryTreeItemDto> masteryTreeItems { get; set; }

            public class MasteryTreeItemDto
            {
                /// <summary>
                /// No description available from Riot Documentation
                /// </summary>
                [JsonProperty(PropertyName = "masteryId")]
                public int MasteryId { get; set; }

                /// <summary>
                /// No description available from Riot Documentation
                /// </summary>
                [JsonProperty(PropertyName = "prereq")]
                public string Prereq { get; set; }
            }
        }
    }
}
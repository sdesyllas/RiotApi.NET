using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Mastery
{
    /// <summary>
    /// This object contains mastery tree data.
    /// </summary>
    [DataContract]
    public class MasteryTreeDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "Defense")]
        public IEnumerable<MasteryTreeListDto> Defense { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "Offense")]
        public IEnumerable<MasteryTreeListDto> Offense { get; set; }

                /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "Utility")]
        public IEnumerable<MasteryTreeListDto> Utility { get; set; }

        [DataContract]
        public class MasteryTreeListDto
        {
            /// <summary>
            /// No description available from Riot Documentation
            /// </summary>
            [DataMember(Name = "masteryTreeItems")]
            public IEnumerable<MasteryTreeItemDto> masteryTreeItems { get; set; }

            [DataContract]
            public class MasteryTreeItemDto
            {
                /// <summary>
                /// No description available from Riot Documentation
                /// </summary>
                [DataMember(Name = "masteryId")]
                public int MasteryId { get; set; }

                /// <summary>
                /// No description available from Riot Documentation
                /// </summary>
                [DataMember(Name = "prereq")]
                public string Prereq { get; set; }
            }
        }
    }
}
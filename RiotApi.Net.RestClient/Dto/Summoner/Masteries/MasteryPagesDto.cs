using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Summoner.Masteries
{
    /// <summary>
    /// This object contains rune pages information.
    /// </summary>
    [DataContract]
    public class MasteryPagesDto : RiotDto
    {

        /// <summary>
        /// Collection of rune pages associated with the summoner.
        /// </summary>
        [DataMember(Name = "pages")]
        public IEnumerable<MasteryPageDto> Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name = "summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// This object contains rune page information.
        /// </summary>
        [DataContract]
        public class MasteryPageDto
        {
            /// <summary>
            /// Indicates if the page is the current page.
            /// </summary>
            [DataMember(Name = "current")]
            public bool Current { get; set; }

            /// <summary>
            /// Mastery page ID.
            /// </summary>
            [DataMember(Name = "id")]
            public long Id { get; set; }

            /// <summary>
            /// Collection of masteries associated with the mastery page.
            /// </summary>
            [DataMember(Name = "masteries")]
            public IEnumerable<MasteryDto> Masteries { get; set; }

            /// <summary>
            /// Mastery page name.
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }

        /// <summary>
        /// This object contains mastery information.
        /// </summary>
        [DataContract]
        public class MasteryDto
        {
            /// <summary>
            /// Mastery ID. For static information correlating to masteries, please refer to the LoL Static Data API.
            /// </summary>
            [DataMember(Name = "id")]
            public int Id { get; set; }

            /// <summary>
            /// Mastery rank (i.e., the number of points put into this mastery).
            /// </summary>
            [DataMember(Name = "rank")]
            public int Rank { get; set; }
        }
    }
}

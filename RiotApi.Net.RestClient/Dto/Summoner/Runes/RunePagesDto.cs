using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Summoner.Runes
{
    /// <summary>
    /// This object contains rune pages information.
    /// </summary>
    [DataContract]
    public class RunePagesDto : RiotDto
    {

        /// <summary>
        /// Collection of rune pages associated with the summoner.
        /// </summary>
        [DataMember(Name = "pages")]
        public IEnumerable<RunePageDto> Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name = "summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// This object contains rune page information.
        /// </summary>
        [DataContract]
        public class RunePageDto
        {
            /// <summary>
            /// Indicates if the page is the current page.
            /// </summary>
            [DataMember(Name = "current")]
            public bool Current { get; set; }

            /// <summary>
            /// Rune page ID.
            /// </summary>
            [DataMember(Name = "id")]
            public long Id { get; set; }

            /// <summary>
            /// Rune page ID.
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Collection of rune slots associated with the rune page.
            /// </summary>
            [DataMember(Name = "slots")]
            public IEnumerable<RuneSlotDto> Slots { get; set; }
        }

        /// <summary>
        /// This object contains rune slot information.
        /// </summary>
        [DataContract]
        public class RuneSlotDto
        {
            /// <summary>
            /// Rune ID associated with the rune slot. For static information correlating to rune IDs, please refer to the LoL Static Data API.
            /// </summary>
            [DataMember(Name = "runeId")]
            public int RuneId { get; set; }

            /// <summary>
            /// Rune slot ID.
            /// </summary>
            [DataMember(Name = "runeSlotId")]
            public int RuneSlotId { get; set; }
        }
    }
}

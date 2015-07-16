using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Net.RestClient.Dto.Summoner.Runes
{
    /// <summary>
    /// This object contains rune pages information.
    /// </summary>
    public class RunePagesDto : RiotDto
    {

        /// <summary>
        /// Collection of rune pages associated with the summoner.
        /// </summary>
        [JsonProperty(PropertyName = "pages")]
        public IEnumerable<RunePageDto> Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty(PropertyName = "summonerId")]
        public long summonerId { get; set; }

        /// <summary>
        /// This object contains rune page information.
        /// </summary>
        public class RunePageDto
        {
            /// <summary>
            /// Indicates if the page is the current page.
            /// </summary>
            [JsonProperty(PropertyName = "current")]
            public bool Current { get; set; }

            /// <summary>
            /// Rune page ID.
            /// </summary>
            [JsonProperty(PropertyName = "id")]
            public long Id { get; set; }

            /// <summary>
            /// Rune page ID.
            /// </summary>
            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            /// <summary>
            /// Collection of rune slots associated with the rune page.
            /// </summary>
            [JsonProperty(PropertyName = "slots")]
            public IEnumerable<RuneSlotDto> Slots { get; set; }
        }

        /// <summary>
        /// This object contains rune slot information.
        /// </summary>
        public class RuneSlotDto
        {
            /// <summary>
            /// Rune ID associated with the rune slot. For static information correlating to rune IDs, please refer to the LoL Static Data API.
            /// </summary>
            [JsonProperty(PropertyName = "runeId")]
            public int RuneId { get; set; }

            /// <summary>
            /// Rune slot ID.
            /// </summary>
            [JsonProperty(PropertyName = "runeSlotId")]
            public int RuneSlotId { get; set; }
        }
    }
}

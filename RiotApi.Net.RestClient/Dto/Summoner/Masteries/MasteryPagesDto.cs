using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Net.RestClient.Dto.Summoner.Masteries
{
    /// <summary>
    /// This object contains rune pages information.
    /// </summary>
    public class MasteryPagesDto : RiotDto
    {

        /// <summary>
        /// Collection of rune pages associated with the summoner.
        /// </summary>
        [JsonProperty(PropertyName = "pages")]
        public IEnumerable<MasteryPageDto> Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty(PropertyName = "summonerId")]
        public long summonerId { get; set; }

        /// <summary>
        /// This object contains rune page information.
        /// </summary>
        public class MasteryPageDto
        {
            /// <summary>
            /// Indicates if the page is the current page.
            /// </summary>
            [JsonProperty(PropertyName = "current")]
            public bool Current { get; set; }

            /// <summary>
            /// Mastery page ID.
            /// </summary>
            [JsonProperty(PropertyName = "id")]
            public long Id { get; set; }

            /// <summary>
            /// Collection of masteries associated with the mastery page.
            /// </summary>
            [JsonProperty(PropertyName = "masteries")]
            public IEnumerable<MasteryDto> Masteries { get; set; }

            /// <summary>
            /// Mastery page name.
            /// </summary>
            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }
        }

        /// <summary>
        /// This object contains mastery information.
        /// </summary>
        public class MasteryDto
        {
            /// <summary>
            /// Mastery ID. For static information correlating to masteries, please refer to the LoL Static Data API.
            /// </summary>
            [JsonProperty(PropertyName = "id")]
            public int Id { get; set; }

            /// <summary>
            /// Mastery rank (i.e., the number of points put into this mastery).
            /// </summary>
            [JsonProperty(PropertyName = "rank")]
            public int Rank { get; set; }
        }
    }
}

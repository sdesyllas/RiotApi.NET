using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Champion
{
    /// <summary>
    /// ChampionListDto - This object contains a collection of champion information.
    /// </summary>
    public class ChampionListDto : RiotDto
    {
        /// <summary>
        /// champions	List[ChampionDto]	The collection of champion information.
        /// </summary>
        [JsonProperty(PropertyName = "champions")]
        public IEnumerable<ChampionDto> Champions { get; set; }

        /// <summary>
        /// ChampionDto - This object contains champion information.
        /// </summary>
        public class ChampionDto : RiotDto
        {
            /// <summary>
            /// active	boolean	Indicates if the champion is active.
            /// </summary>
            [JsonProperty(PropertyName = "active")]
            public bool Active { get; set; }

            /// <summary>
            /// botEnabled	boolean	Bot enabled flag (for custom games).
            /// </summary>
            [JsonProperty(PropertyName = "botEnabled")]
            public bool botEnabled { get; set; }

            /// <summary>
            ///  botMmEnabled	boolean	Bot Match Made enabled flag (for Co-op vs. AI games).
            /// </summary>
            [JsonProperty(PropertyName = "botMmEnabled")]
            public bool BotMmEnabled { get; set; }

            /// <summary>
            ///  freeToPlay boolean Indicates if the champion is free to play.
            /// Free to play champions are rotated periodically.
            /// </summary>
            [JsonProperty(PropertyName = "freeToPlay")]
            public bool FreeToPlay { get; set; }

            /// <summary>
            /// id long Champion ID.For static information correlating to champion IDs, please refer to the LoL Static Data API.
            /// </summary>
            [JsonProperty(PropertyName = "id")]
            public long Id { get; set; }

            /// <summary>
            /// rankedPlayEnabled   boolean Ranked play enabled flag.
            /// </summary>
            [JsonProperty(PropertyName = "rankedPlayEnabled")]
            public bool RankedPlayEnabled { get; set; }
        }
    }
}

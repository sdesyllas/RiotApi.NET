using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Champion
{
    /// <summary>
    /// ChampionListDto - This object contains a collection of champion information.
    /// </summary>
    [DataContract]
    public class ChampionListDto : RiotDto
    {
        /// <summary>
        /// champions	List[ChampionDto]	The collection of champion information.
        /// </summary>
        [DataMember(Name = "champions")]
        public IEnumerable<ChampionDto> Champions { get; set; }

        /// <summary>
        /// ChampionDto - This object contains champion information.
        /// </summary>
        [DataContract]
        public class ChampionDto : RiotDto
        {
            /// <summary>
            /// active	boolean	Indicates if the champion is active.
            /// </summary>
            [DataMember(Name = "active")]
            public bool Active { get; set; }

            /// <summary>
            /// botEnabled	boolean	Bot enabled flag (for custom games).
            /// </summary>
            [DataMember(Name = "botEnabled")]
            public bool BotEnabled { get; set; }

            /// <summary>
            ///  botMmEnabled	boolean	Bot Match Made enabled flag (for Co-op vs. AI games).
            /// </summary>
            [DataMember(Name = "botMmEnabled")]
            public bool BotMmEnabled { get; set; }

            /// <summary>
            ///  freeToPlay boolean Indicates if the champion is free to play.
            /// Free to play champions are rotated periodically.
            /// </summary>
            [DataMember(Name = "freeToPlay")]
            public bool FreeToPlay { get; set; }

            /// <summary>
            /// id long Champion ID.For static information correlating to champion IDs, please refer to the LoL Static Data API.
            /// </summary>
            [DataMember(Name = "id")]
            public long Id { get; set; }

            /// <summary>
            /// rankedPlayEnabled   boolean Ranked play enabled flag.
            /// </summary>
            [DataMember(Name = "rankedPlayEnabled")]
            public bool RankedPlayEnabled { get; set; }
        }
    }
}

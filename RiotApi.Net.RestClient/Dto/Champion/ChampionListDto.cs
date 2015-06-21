using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Champion
{
    /// <summary>
    /// ChampionListDto - This object contains a collection of champion information.
    /// </summary>
    public class ChampionListDto
    {
        /// <summary>
        /// champions	List[ChampionDto]	The collection of champion information.
        /// </summary>
        [JsonProperty(PropertyName = "champions")]
        public IEnumerable<ChampionDto> Champions { get; set; }
    }
}

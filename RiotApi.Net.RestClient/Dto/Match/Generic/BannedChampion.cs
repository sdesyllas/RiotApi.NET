using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains information about banned champions
    /// </summary>
    public class BannedChampion
    {
        /// <summary>
        /// Banned champion ID
        /// </summary>
        [JsonProperty(PropertyName = "championId")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Turn during which the champion was banned
        /// </summary>
        [JsonProperty(PropertyName = "pickTurn")]
        public int PickTurn { get; set; }
    }
}

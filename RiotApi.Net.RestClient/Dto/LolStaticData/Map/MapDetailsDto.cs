using Newtonsoft.Json;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Map
{
    /// <summary>
    /// This object contains map details data. 
    /// </summary>
    public class MapDetailsDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public ImageDto image { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "mapId")]
        public long MapId { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "mapName")]
        public string MapName { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "unpurchasableItemList")]
        public IEnumerable<long> UnpurchasableItemList { get; set; }
    }
}

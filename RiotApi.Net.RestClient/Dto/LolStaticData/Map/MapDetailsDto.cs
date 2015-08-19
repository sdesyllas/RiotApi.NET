using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Map
{
    /// <summary>
    /// This object contains map details data. 
    /// </summary>
    [DataContract]
    public class MapDetailsDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "image")]
        public ImageDto Image { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "mapId")]
        public long MapId { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "mapName")]
        public string MapName { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "unpurchasableItemList")]
        public IEnumerable<long> UnpurchasableItemList { get; set; }
    }
}

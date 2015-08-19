using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains champion recommended block item data.
    /// </summary>
    [DataContract]
    public class BlockItemDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "count")]
        public int Count { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Item
{
    /// <summary>
    /// This object contains item tree data.
    /// </summary>
    [DataContract]
    public class ItemTreeDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "header")]
        public string Header { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "tags")]
        public IEnumerable<string> Tags { get; set; }
    }
}

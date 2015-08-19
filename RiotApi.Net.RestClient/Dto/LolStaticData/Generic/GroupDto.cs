using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains item group data.
    /// </summary>
    [DataContract]
    public class GroupDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "key")]
        public string Key { get; set; }
    }
}

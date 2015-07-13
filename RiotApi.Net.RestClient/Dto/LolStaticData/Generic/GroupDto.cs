using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Generic
{
    /// <summary>
    /// This object contains item group data.
    /// </summary>
    public class GroupDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
    }
}

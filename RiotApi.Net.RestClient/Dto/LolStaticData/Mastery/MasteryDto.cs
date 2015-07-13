using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Mastery
{
    /// <summary>
    /// This object contains mastery data.
    /// </summary>
    public class MasteryDto : RiotDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public IEnumerable<string> Description { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public ImageDto Image { get; set; }

        /// <summary>
        /// Legal values: Defense, Offense, Utility
        /// </summary>
        [JsonProperty(PropertyName = "masteryTree")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.MasteryTree MasteryTree { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "prereq")]
        public string Prereq { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "ranks")]
        public int Ranks { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "sanitizedDescription")]
        public IEnumerable<string> SanitizedDescription { get; set; }
    }
}

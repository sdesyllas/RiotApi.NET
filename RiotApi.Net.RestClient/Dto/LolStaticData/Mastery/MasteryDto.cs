using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Mastery
{
    /// <summary>
    /// This object contains mastery data.
    /// </summary>
    [DataContract]
    public class MasteryDto : RiotDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "description")]
        public IEnumerable<string> Description { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "image")]
        public ImageDto Image { get; set; }

        /// <summary>
        /// Legal values: Defense, Offense, Utility
        /// </summary>
        [DataMember(Name = "masteryTree")]
        public Helpers.Enums.MasteryTree MasteryTree { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "prereq")]
        public string Prereq { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "ranks")]
        public int Ranks { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "sanitizedDescription")]
        public IEnumerable<string> SanitizedDescription { get; set; }
    }
}

using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Rune
{
    /// <summary>
    /// RuneDto - This object contains rune data.
    /// </summary>
    [DataContract]
    public class RuneDto : RiotDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "colloq")]
        public string Colloq { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "consumeOnFull")]
        public bool ConsumeOnFull { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "consumed")]
        public bool Consumed { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "depth")]
        public int Depth { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "from")]
        public IEnumerable<string> From { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "group")]
        public string Group { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "hideFromAll")]
        public bool HideFromAll { get; set; }

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
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "inStore")]
        public bool InStore { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "into")]
        public IEnumerable<string> Into { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "maps")]
        public Dictionary<string, bool> Maps { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "plaintext")]
        public string Plaintext { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "requiredChampion")]
        public string RequiredChampion { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "rune")]
        public MetaDataDto Rune { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "specialRecipe")]
        public int SpecialRecipe { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "stacks")]
        public int Stacks { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "stats")]
        public BasicDataStatsDto Stats { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [DataMember(Name = "tags")]
        public IEnumerable<string> Tags { get; set; }
    }
}

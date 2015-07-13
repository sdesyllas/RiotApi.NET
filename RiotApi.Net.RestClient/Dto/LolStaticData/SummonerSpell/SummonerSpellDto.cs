using Newtonsoft.Json;
using RiotApi.Net.RestClient.Dto.LolStaticData.Generic;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.SummonerSpell
{
    /// <summary>
    /// This object contains summoner spell data.
    /// </summary>
    public class SummonerSpellDto : RiotDto
    {
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "cooldown")]
        public IEnumerable<double> Cooldown { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "cooldownBurn")]
        public string CooldownBurn { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public IEnumerable<int> Cost { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "costBurn")]
        public string CostBurn { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "costType")]
        public string CostType { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// This field is a List of List of Double. List[object] as documented by Riot 
        /// </summary>
        [JsonProperty(PropertyName = "effect")]
        public List<List<double>> Effect { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "effectBurn")]
        public List<string> EffectBurn { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public List<ImageDto> Image { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "leveltip")]
        public LevelTipDto Leveltip { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "maxrank")]
        public int Maxrank { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "modes")]
        public IEnumerable<string> Modes { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// This field is either a List of Integer or the String 'self' for spells that target one's own champion.
        /// </summary>
        [JsonProperty(PropertyName = "range")]
        public object Range { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "rangeBurn")]
        public string RangeBurn { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "sanitizedTooltip")]
        public string SanitizedTooltip { get; set; }
        
        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "summonerLevel")]
        public int SummonerLevel { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "tooltip")]
        public string Tooltip { get; set; }

        /// <summary>
        /// No description available from Riot Documentation
        /// </summary>
        [JsonProperty(PropertyName = "vars")]
        public IEnumerable<SpellVarsDto> Vars { get; set; }
    }
}

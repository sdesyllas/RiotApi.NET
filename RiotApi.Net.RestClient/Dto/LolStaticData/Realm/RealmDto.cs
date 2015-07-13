using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Realm
{
    /// <summary>
    /// This object contains realm data.
    /// </summary>
    public class RealmDto : RiotDto
    {
        /// <summary>
        /// The base CDN url.
        /// </summary>
        [JsonProperty(PropertyName = "cdn")]
        public string Cdn { get; set; }

        /// <summary>
        /// Latest changed version of Dragon Magic's css file.
        /// </summary>
        [JsonProperty(PropertyName = "css")]
        public string Css { get; set; }

        /// <summary>
        /// Latest changed version of Dragon Magic.
        /// </summary>
        [JsonProperty(PropertyName = "dd")]
        public string Dd { get; set; }

        /// <summary>
        /// Default language for this realm.
        /// </summary>
        [JsonProperty(PropertyName = "l")]
        public string L { get; set; }

        /// <summary>
        /// Legacy script mode for IE6 or older.
        /// </summary>
        [JsonProperty(PropertyName = "lg")]
        public string Lg { get; set; }

        /// <summary>
        /// Latest changed version for each data type listed.
        /// </summary>
        [JsonProperty(PropertyName = "n")]
        public Dictionary<string, string> N { get; set; }

        /// <summary>
        /// Special behavior number identifying the largest profileicon id that can be used under 500. 
        /// Any profileicon that is requested between this number and 500 should be mapped to 0.
        /// </summary>
        [JsonProperty(PropertyName = "profileiconmax")]
        public int Profileiconmax { get; set; }

        /// <summary>
        /// Additional api data drawn from other sources that may be related to data dragon functionality.
        /// </summary>
        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }

        /// <summary>
        /// Current version of this file for this realm.
        /// </summary>
        [JsonProperty(PropertyName = "v")]
        public string V { get; set; }
    }
}

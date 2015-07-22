using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;

namespace RiotApi.Net.RestClient.Dto.LolStatus
{
    /// <summary>
    /// LOL Status for each shard
    /// </summary>
    public class ShardStatusDto : RiotDto
    {
        /// <summary>
        /// hostname	string
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string HostName { get; set; }

        /// <summary>
        /// locales	List[string]
        /// </summary>
        [JsonProperty(PropertyName = "locales")]
        public IEnumerable<string> Locales { get; set; }

        /// <summary>
        /// name	string
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public IEnumerable<string> Name { get; set; }

        /// <summary>
        /// region_tag	string
        /// </summary>
        [JsonProperty(PropertyName = "region_tag")]
        public IEnumerable<string> RegionTag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IEnumerable<Service> Services { get; set; }

        /// <summary>
        /// slug string
        /// </summary>
        [JsonProperty(PropertyName = "slug")]
        public IEnumerable<string> Slug { get; set; }

        
        /// <summary>
        /// Service
        /// </summary>
        public class Service
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "incidents")]
            public IEnumerable<Incident> Incidents { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "slug")]
            public string Slug { get; set; }

            /// <summary>
            /// Legal values: Online, Alert, Offline, Deploying
            /// </summary>
            [JsonProperty(PropertyName = "status")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Helpers.Enums.ServiceStatus Status { get; set; }
        }

        /// <summary>
        /// Incident
        /// </summary>
        public class Incident
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "active")]
            public bool Active { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "created_at")]
            public string CreatedAt { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "id")]
            public long Id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty(PropertyName = "updates")]
            public IEnumerable<Message> Updates { get; set; }
        }

        /// <summary>
        /// Message
        /// </summary>
        public class Message
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "author")]
            public string Author { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "content")]
            public string Content { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "created_at")]
            public string CreateAt { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "id")]
            public long Id { get; set; }

            /// <summary>
            /// Legal values: Info, Alert, Error
            /// </summary>
            [JsonProperty(PropertyName = "severity")]
            [JsonConverter(typeof(StringEnumConverter))]
            public Helpers.Enums.MessageSeverity Severity { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "translations")]
            public IEnumerable<Translation> Translations { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "updated_at")]
            public string UpdatedAt { get; set; }
        }

        /// <summary>
        /// Translation
        /// </summary>
        public class Translation
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "content")]
            public string Content { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "locale")]
            public string Locale { get; set; }
            
            /// <summary>
            ///
            /// </summary>
            [JsonProperty(PropertyName = "updated_at")]
            public string UpdatedAt { get; set; }
        }
    }
}

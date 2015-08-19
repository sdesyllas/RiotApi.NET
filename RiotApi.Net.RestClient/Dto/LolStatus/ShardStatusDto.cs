using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStatus
{
    /// <summary>
    /// LOL Status for each shard
    /// </summary>
    [DataContract]
    public class ShardStatusDto : RiotDto
    {
        /// <summary>
        /// hostname	string
        /// </summary>
        [DataMember(Name = "hostname")]
        public string HostName { get; set; }

        /// <summary>
        /// locales	List[string]
        /// </summary>
        [DataMember(Name = "locales")]
        public IEnumerable<string> Locales { get; set; }

        /// <summary>
        /// name	string
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// region_tag	string
        /// </summary>
        [DataMember(Name = "region_tag")]
        public string RegionTag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "services")]
        public IEnumerable<Service> Services { get; set; }

        /// <summary>
        /// slug string
        /// </summary>
        [DataMember(Name = "slug")]
        public string Slug { get; set; }


        /// <summary>
        /// Service
        /// </summary>
        [DataContract]
        public class Service
        {
            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "incidents")]
            public IEnumerable<Incident> Incidents { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "slug")]
            public string Slug { get; set; }

            /// <summary>
            /// Legal values: Online, Alert, Offline, Deploying
            /// </summary>
            [DataMember(Name = "status")]
            public Helpers.Enums.ServiceStatus Status { get; set; }
        }

        /// <summary>
        /// Incident
        /// </summary>
        [DataContract]
        public class Incident
        {
            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "active")]
            public bool Active { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "created_at")]
            public string CreatedAt { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "id")]
            public long Id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember(Name = "updates")]
            public IEnumerable<Message> Updates { get; set; }
        }

        /// <summary>
        /// Message
        /// </summary>
        [DataContract]
        public class Message
        {
            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "author")]
            public string Author { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "content")]
            public string Content { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "created_at")]
            public string CreateAt { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "id")]
            public long Id { get; set; }

            /// <summary>
            /// Legal values: Info, Alert, Error
            /// </summary>
            [DataMember(Name = "severity")]
            public Helpers.Enums.MessageSeverity Severity { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "translations")]
            public IEnumerable<Translation> Translations { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "updated_at")]
            public string UpdatedAt { get; set; }
        }

        /// <summary>
        /// Translation
        /// </summary>
        [DataContract]
        public class Translation
        {
            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "content")]
            public string Content { get; set; }

            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "locale")]
            public string Locale { get; set; }
            
            /// <summary>
            ///
            /// </summary>
            [DataMember(Name = "updated_at")]
            public string UpdatedAt { get; set; }
        }
    }
}

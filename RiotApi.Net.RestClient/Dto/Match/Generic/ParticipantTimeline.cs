using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains all timeline information
    /// </summary>
    public class ParticipantTimeline
    {
        /// <summary>
        /// Ancient golem assists per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "ancientGolemAssistsPerMinCounts")]
        public ParticipantTimelineData AncientGolemAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Ancient golem kills per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "ancientGolemKillsPerMinCounts")]
        public ParticipantTimelineData AncientGolemKillsPerMinCounts { get; set; }

        /// <summary>
        /// Assisted lane deaths per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "assistedLaneDeathsPerMinDeltas")]
        public ParticipantTimelineData AssistedLaneDeathsPerMinDeltas { get; set; }

        /// <summary>
        /// Assisted lane kills per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "assistedLaneKillsPerMinDeltas")]
        public ParticipantTimelineData AssistedLaneKillsPerMinDeltas { get; set; }

        /// <summary>
        /// Baron assists per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "baronAssistsPerMinCounts")]
        public ParticipantTimelineData BaronAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Baron kills per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "baronKillsPerMinCounts")]
        public ParticipantTimelineData BaronKillsPerMinCounts { get; set; }

        /// <summary>
        /// Creeps per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "creepsPerMinDeltas")]
        public ParticipantTimelineData CreepsPerMinDeltas { get; set; }

        /// <summary>
        /// Creep score difference per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "csDiffPerMinDeltas")]
        public ParticipantTimelineData CsDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Damage taken difference per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "damageTakenDiffPerMinDeltas")]
        public ParticipantTimelineData DamageTakenDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Damage taken per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "damageTakenPerMinDeltas")]
        public ParticipantTimelineData DamageTakenPerMinDeltas { get; set; }

        /// <summary>
        /// Dragon assists per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "dragonAssistsPerMinCounts")]
        public ParticipantTimelineData dragonAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Dragon kills per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "dragonKillsPerMinCounts")]
        public ParticipantTimelineData DragonKillsPerMinCounts { get; set; }

        /// <summary>
        /// Elder lizard assists per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "elderLizardAssistsPerMinCounts")]
        public ParticipantTimelineData ElderLizardAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Elder lizard kills per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "elderLizardKillsPerMinCounts")]
        public ParticipantTimelineData ElderLizardKillsPerMinCounts { get; set; }

        /// <summary>
        /// Gold per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "goldPerMinDeltas")]
        public ParticipantTimelineData GoldPerMinDeltas { get; set; }

        /// <summary>
        /// Inhibitor assists per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "inhibitorAssistsPerMinCounts")]
        public ParticipantTimelineData InhibitorAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Inhibitor kills per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "inhibitorKillsPerMinCounts")]
        public ParticipantTimelineData InhibitorKillsPerMinCounts { get; set; }

        /// <summary>
        /// Participant's lane (Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM)
        /// </summary>
        [JsonProperty(PropertyName = "lane")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.Lane Lane { get; set; }

        /// <summary>
        /// Participant's role (Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT)
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.Role Role { get; set; }

        /// <summary>
        /// Tower assists per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "towerAssistsPerMinCounts")]
        public ParticipantTimelineData TowerAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Tower kills per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "towerKillsPerMinCounts")]
        public ParticipantTimelineData TowerKillsPerMinCounts { get; set; }

        /// <summary>
        /// Tower kills per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "towerKillsPerMinDeltas")]
        public ParticipantTimelineData TowerKillsPerMinDeltas { get; set; }

        /// <summary>
        /// Vilemaw assists per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "vilemawAssistsPerMinCounts")]
        public ParticipantTimelineData VilemawAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Vilemaw kills per minute timeline counts
        /// </summary>
        [JsonProperty(PropertyName = "vilemawKillsPerMinCounts")]
        public ParticipantTimelineData VilemawKillsPerMinCounts { get; set; }

        /// <summary>
        /// Wards placed per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "wardsPerMinDeltas")]
        public ParticipantTimelineData WardsPerMinDeltas { get; set; }

        /// <summary>
        /// Experience difference per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "xpDiffPerMinDeltas")]
        public ParticipantTimelineData XpDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Experience per minute timeline data
        /// </summary>
        [JsonProperty(PropertyName = "xpPerMinDeltas")]
        public ParticipantTimelineData XpPerMinDeltas { get; set; }
    }
}

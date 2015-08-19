using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains all timeline information
    /// </summary>
    [DataContract]
    public class ParticipantTimeline
    {
        /// <summary>
        /// Ancient golem assists per minute timeline counts
        /// </summary>
        [DataMember(Name = "ancientGolemAssistsPerMinCounts")]
        public ParticipantTimelineData AncientGolemAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Ancient golem kills per minute timeline counts
        /// </summary>
        [DataMember(Name = "ancientGolemKillsPerMinCounts")]
        public ParticipantTimelineData AncientGolemKillsPerMinCounts { get; set; }

        /// <summary>
        /// Assisted lane deaths per minute timeline data
        /// </summary>
        [DataMember(Name = "assistedLaneDeathsPerMinDeltas")]
        public ParticipantTimelineData AssistedLaneDeathsPerMinDeltas { get; set; }

        /// <summary>
        /// Assisted lane kills per minute timeline data
        /// </summary>
        [DataMember(Name = "assistedLaneKillsPerMinDeltas")]
        public ParticipantTimelineData AssistedLaneKillsPerMinDeltas { get; set; }

        /// <summary>
        /// Baron assists per minute timeline counts
        /// </summary>
        [DataMember(Name = "baronAssistsPerMinCounts")]
        public ParticipantTimelineData BaronAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Baron kills per minute timeline counts
        /// </summary>
        [DataMember(Name = "baronKillsPerMinCounts")]
        public ParticipantTimelineData BaronKillsPerMinCounts { get; set; }

        /// <summary>
        /// Creeps per minute timeline data
        /// </summary>
        [DataMember(Name = "creepsPerMinDeltas")]
        public ParticipantTimelineData CreepsPerMinDeltas { get; set; }

        /// <summary>
        /// Creep score difference per minute timeline data
        /// </summary>
        [DataMember(Name = "csDiffPerMinDeltas")]
        public ParticipantTimelineData CsDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Damage taken difference per minute timeline data
        /// </summary>
        [DataMember(Name = "damageTakenDiffPerMinDeltas")]
        public ParticipantTimelineData DamageTakenDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Damage taken per minute timeline data
        /// </summary>
        [DataMember(Name = "damageTakenPerMinDeltas")]
        public ParticipantTimelineData DamageTakenPerMinDeltas { get; set; }

        /// <summary>
        /// Dragon assists per minute timeline counts
        /// </summary>
        [DataMember(Name = "dragonAssistsPerMinCounts")]
        public ParticipantTimelineData dragonAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Dragon kills per minute timeline counts
        /// </summary>
        [DataMember(Name = "dragonKillsPerMinCounts")]
        public ParticipantTimelineData DragonKillsPerMinCounts { get; set; }

        /// <summary>
        /// Elder lizard assists per minute timeline counts
        /// </summary>
        [DataMember(Name = "elderLizardAssistsPerMinCounts")]
        public ParticipantTimelineData ElderLizardAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Elder lizard kills per minute timeline counts
        /// </summary>
        [DataMember(Name = "elderLizardKillsPerMinCounts")]
        public ParticipantTimelineData ElderLizardKillsPerMinCounts { get; set; }

        /// <summary>
        /// Gold per minute timeline data
        /// </summary>
        [DataMember(Name = "goldPerMinDeltas")]
        public ParticipantTimelineData GoldPerMinDeltas { get; set; }

        /// <summary>
        /// Inhibitor assists per minute timeline counts
        /// </summary>
        [DataMember(Name = "inhibitorAssistsPerMinCounts")]
        public ParticipantTimelineData InhibitorAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Inhibitor kills per minute timeline counts
        /// </summary>
        [DataMember(Name = "inhibitorKillsPerMinCounts")]
        public ParticipantTimelineData InhibitorKillsPerMinCounts { get; set; }

        /// <summary>
        /// Participant's lane (Legal values: MID, MIDDLE, TOP, JUNGLE, BOT, BOTTOM)
        /// </summary>
        [DataMember(Name = "lane")]
        public Helpers.Enums.Lane Lane { get; set; }

        /// <summary>
        /// Participant's role (Legal values: DUO, NONE, SOLO, DUO_CARRY, DUO_SUPPORT)
        /// </summary>
        [DataMember(Name = "role")]
        public Helpers.Enums.Role Role { get; set; }

        /// <summary>
        /// Tower assists per minute timeline counts
        /// </summary>
        [DataMember(Name = "towerAssistsPerMinCounts")]
        public ParticipantTimelineData TowerAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Tower kills per minute timeline counts
        /// </summary>
        [DataMember(Name = "towerKillsPerMinCounts")]
        public ParticipantTimelineData TowerKillsPerMinCounts { get; set; }

        /// <summary>
        /// Tower kills per minute timeline data
        /// </summary>
        [DataMember(Name = "towerKillsPerMinDeltas")]
        public ParticipantTimelineData TowerKillsPerMinDeltas { get; set; }

        /// <summary>
        /// Vilemaw assists per minute timeline counts
        /// </summary>
        [DataMember(Name = "vilemawAssistsPerMinCounts")]
        public ParticipantTimelineData VilemawAssistsPerMinCounts { get; set; }

        /// <summary>
        /// Vilemaw kills per minute timeline counts
        /// </summary>
        [DataMember(Name = "vilemawKillsPerMinCounts")]
        public ParticipantTimelineData VilemawKillsPerMinCounts { get; set; }

        /// <summary>
        /// Wards placed per minute timeline data
        /// </summary>
        [DataMember(Name = "wardsPerMinDeltas")]
        public ParticipantTimelineData WardsPerMinDeltas { get; set; }

        /// <summary>
        /// Experience difference per minute timeline data
        /// </summary>
        [DataMember(Name = "xpDiffPerMinDeltas")]
        public ParticipantTimelineData XpDiffPerMinDeltas { get; set; }

        /// <summary>
        /// Experience per minute timeline data
        /// </summary>
        [DataMember(Name = "xpPerMinDeltas")]
        public ParticipantTimelineData XpPerMinDeltas { get; set; }
    }
}

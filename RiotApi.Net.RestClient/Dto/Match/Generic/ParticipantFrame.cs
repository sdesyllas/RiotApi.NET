using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains participant frame information
    /// </summary>
    [DataContract]
    public class ParticipantFrame : RiotDto
    {
        /// <summary>
        /// Participant's current gold
        /// </summary>
        [DataMember(Name = "currentGold")]
        public int CurrentGold { get; set; }

        /// <summary>
        /// Dominion score of the participant
        /// </summary>
        [DataMember(Name = "dominionScore")]
        public int DominionScore { get; set; }

        /// <summary>
        /// Number of jungle minions killed by participant
        /// </summary>
        [DataMember(Name = "jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }

        /// <summary>
        /// Participant's current level
        /// </summary>
        [DataMember(Name = "level")]
        public int Level { get; set; }

        /// <summary>
        /// Number of minions killed by participant
        /// </summary>
        [DataMember(Name = "minionsKilled")]
        public int MinionsKilled { get; set; }

        /// <summary>
        /// Participant ID
        /// </summary>
        [DataMember(Name = "participantId")]
        public int ParticipantId { get; set; }

        /// <summary>
        /// Participant's position
        /// </summary>
        [DataMember(Name = "position")]
        public Position Position { get; set; }

        /// <summary>
        /// Team score of the participant
        /// </summary>
        [DataMember(Name = "teamScore")]
        public int TeamScore { get; set; }

        /// <summary>
        /// Participant's total gold
        /// </summary>
        [DataMember(Name = "totalGold")]
        public int TotalGold { get; set; }

        /// <summary>
        /// Experience earned by participant
        /// </summary>
        [DataMember(Name = "xp")]
        public int Xp { get; set; }
    }
}

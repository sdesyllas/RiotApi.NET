using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains participant identity information
    /// </summary>
    [DataContract]
    public class ParticipantIdentity
    {
        /// <summary>
        /// Participant ID
        /// </summary>
        [DataMember(Name = "participantId")]
        public int ParticipantId { get; set; }

        /// <summary>
        /// Player information
        /// </summary>
        [DataMember(Name = "player")]
        public Player Player { get; set; }
    }
}

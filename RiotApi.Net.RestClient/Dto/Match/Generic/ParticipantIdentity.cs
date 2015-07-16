using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains participant identity information
    /// </summary>
    public class ParticipantIdentity
    {
        /// <summary>
        /// Participant ID
        /// </summary>
        [JsonProperty(PropertyName = "participantId")]
        public int ParticipantId { get; set; }

        /// <summary>
        /// Player information
        /// </summary>
        [JsonProperty(PropertyName = "player")]
        public Player Player { get; set; }
    }
}

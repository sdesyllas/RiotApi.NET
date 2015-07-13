using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains participant frame information
    /// </summary>
    public class ParticipantFrame
    {
        /// <summary>
        /// Participant's current gold
        /// </summary>
        [JsonProperty(PropertyName = "currentGold")]
        public int CurrentGold { get; set; }

        /// <summary>
        /// Dominion score of the participant
        /// </summary>
        [JsonProperty(PropertyName = "dominionScore")]
        public int DominionScore { get; set; }

        /// <summary>
        /// Number of jungle minions killed by participant
        /// </summary>
        [JsonProperty(PropertyName = "jungleMinionsKilled")]
        public int JungleMinionsKilled { get; set; }

        /// <summary>
        /// Participant's current level
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        /// <summary>
        /// Number of minions killed by participant
        /// </summary>
        [JsonProperty(PropertyName = "minionsKilled")]
        public int MinionsKilled { get; set; }

        /// <summary>
        /// Participant ID
        /// </summary>
        [JsonProperty(PropertyName = "participantId")]
        public int ParticipantId { get; set; }

        /// <summary>
        /// Participant's position
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }

        /// <summary>
        /// Team score of the participant
        /// </summary>
        [JsonProperty(PropertyName = "teamScore")]
        public int TeamScore { get; set; }

        /// <summary>
        /// Participant's total gold
        /// </summary>
        [JsonProperty(PropertyName = "totalGold")]
        public int TotalGold { get; set; }

        /// <summary>
        /// Experience earned by participant
        /// </summary>
        [JsonProperty(PropertyName = "xp")]
        public int Xp { get; set; }
    }
}

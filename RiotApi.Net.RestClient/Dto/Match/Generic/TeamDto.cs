using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains team information
    /// </summary>
    [JsonObject(Title = "Team")]
    public class TeamDto
    {
        /// <summary>
        /// If game was draft mode, contains banned champion data, otherwise null
        /// </summary>
        [JsonProperty(PropertyName = "bans")]
        public IEnumerable<BannedChampion> Bans { get; set; }

        /// <summary>
        /// Number of times the team killed baron
        /// </summary>
        [JsonProperty(PropertyName = "baronKills")]
        public int BaronKills { get; set; }

        /// <summary>
        /// If game was a dominion game, specifies the points the team had at game end, otherwise null
        /// </summary>
        [JsonProperty(PropertyName = "dominionVictoryScore")]
        public long DominionVictoryScore { get; set; }

        /// <summary>
        /// Number of times the team killed dragon
        /// </summary>
        [JsonProperty(PropertyName = "dragonKills")]
        public int DragonKills { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team got the first baron kill
        /// </summary>
        [JsonProperty(PropertyName = "firstBaron")]
        public bool FirstBaron { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team got first blood
        /// </summary>
        [JsonProperty(PropertyName = "firstBlood")]
        public bool FirstBlood { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team got the first dragon kill
        /// </summary>
        [JsonProperty(PropertyName = "firstDragon")]
        public bool FirstDragon { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team destroyed the first inhibitor
        /// </summary>
        [JsonProperty(PropertyName = "firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team destroyed the first tower
        /// </summary>
        [JsonProperty(PropertyName = "firstTower")]
        public bool FirstTower { get; set; }

        /// <summary>
        /// Number of inhibitors the team destroyed
        /// </summary>
        [JsonProperty(PropertyName = "inhibitorKills")]
        public int InhibitorKills { get; set; }

        /// <summary>
        /// Team ID
        /// </summary>
        [JsonProperty(PropertyName = "teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Number of towers the team destroyed
        /// </summary>
        [JsonProperty(PropertyName = "towerKills")]
        public int TowerKills { get; set; }

        /// <summary>
        /// Number of times the team killed vilemaw
        /// </summary>
        [JsonProperty(PropertyName = "vilemawKills")]
        public int VilemawKills { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team won
        /// </summary>
        [JsonProperty(PropertyName = "winner")]
        public bool Winner { get; set; }
    }
}

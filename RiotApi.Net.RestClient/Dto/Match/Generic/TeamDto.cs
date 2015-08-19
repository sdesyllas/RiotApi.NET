using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains team information
    /// </summary>
    [DataContract(Name = "Team")]
    public class TeamDto
    {
        /// <summary>
        /// If game was draft mode, contains banned champion data, otherwise null
        /// </summary>
        [DataMember(Name = "bans")]
        public IEnumerable<BannedChampion> Bans { get; set; }

        /// <summary>
        /// Number of times the team killed baron
        /// </summary>
        [DataMember(Name = "baronKills")]
        public int BaronKills { get; set; }

        /// <summary>
        /// If game was a dominion game, specifies the points the team had at game end, otherwise null
        /// </summary>
        [DataMember(Name = "dominionVictoryScore")]
        public long DominionVictoryScore { get; set; }

        /// <summary>
        /// Number of times the team killed dragon
        /// </summary>
        [DataMember(Name = "dragonKills")]
        public int DragonKills { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team got the first baron kill
        /// </summary>
        [DataMember(Name = "firstBaron")]
        public bool FirstBaron { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team got first blood
        /// </summary>
        [DataMember(Name = "firstBlood")]
        public bool FirstBlood { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team got the first dragon kill
        /// </summary>
        [DataMember(Name = "firstDragon")]
        public bool FirstDragon { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team destroyed the first inhibitor
        /// </summary>
        [DataMember(Name = "firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team destroyed the first tower
        /// </summary>
        [DataMember(Name = "firstTower")]
        public bool FirstTower { get; set; }

        /// <summary>
        /// Number of inhibitors the team destroyed
        /// </summary>
        [DataMember(Name = "inhibitorKills")]
        public int InhibitorKills { get; set; }

        /// <summary>
        /// Team ID
        /// </summary>
        [DataMember(Name = "teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Number of towers the team destroyed
        /// </summary>
        [DataMember(Name = "towerKills")]
        public int TowerKills { get; set; }

        /// <summary>
        /// Number of times the team killed vilemaw
        /// </summary>
        [DataMember(Name = "vilemawKills")]
        public int VilemawKills { get; set; }

        /// <summary>
        /// Flag indicating whether or not the team won
        /// </summary>
        [DataMember(Name = "winner")]
        public bool Winner { get; set; }
    }
}

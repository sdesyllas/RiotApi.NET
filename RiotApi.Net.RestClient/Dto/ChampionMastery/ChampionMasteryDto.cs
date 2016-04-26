using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.ChampionMastery
{
    /// <summary>
    /// ChampionMasteryDTO - This object contains single Champion Mastery information for player and champion combination.
    /// </summary>
    [DataContract]
    public class ChampionMasteryDto: RiotDto
    {
        /// <summary>
        /// Champion ID for this entry.
        /// </summary>
        [DataMember(Name = "championId")]
        public long ChampionID { get; set; }

        /// <summary>
        /// Champion level for specified player and champion combination.
        /// </summary>
        [DataMember(Name = "championLevel")]
        public int ChampionLevel { get; set; }

        /// <summary>
        ///  Total number of champion points for this player and champion combination - they are used to determine championLevel.
        /// </summary>
        [DataMember(Name = "championPoints")]
        public int ChampionPoints { get; set; }

        /// <summary>
        ///  Number of points earned since current level has been achieved. Zero if player reached maximum champion level for this champion.
        /// </summary>
        [DataMember(Name = "championPointsSinceLastLevel")]
        public long ChampionPointsSinceLastLevel { get; set; }

        /// <summary>
        ///  Number of points needed to achieve next level. Zero if player reached maximum champion level for this champion.
        /// </summary>
        [DataMember(Name = "championPointsUntilNextLevel")]
        public long ChampionPointsUntilNextLevel { get; set; }

        /// <summary>
        ///  Is chest granted for this champion or not in current season.
        /// </summary>
        [DataMember(Name = "chestGranted")]
        public bool ChestGranted { get; set; }

        /// <summary>
        ///  The highest grade of this champion of current season.
        /// </summary>
        [DataMember(Name = "highestGrade")]
        public string HighestGrade { get; set; }

        /// <summary>
        ///  Last time this champion was played by this player - in Unix milliseconds time format.
        /// </summary>
        [DataMember(Name = "lastPlayTime")]
        public long LastPlayTime { get; set; }

        /// <summary>
        ///  Player ID for this entry.
        /// </summary>
        [DataMember(Name = "playerId")]
        public long PlayerId { get; set; }
    }
}

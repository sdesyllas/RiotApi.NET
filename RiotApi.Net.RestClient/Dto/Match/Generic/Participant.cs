using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains match participant information
    /// </summary>
    [DataContract]
    public class Participant
    {
        /// <summary>
        /// Champion ID
        /// </summary>
        [DataMember(Name = "championId")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Highest ranked tier achieved for the previous season, if any, otherwise null. 
        /// Used to display border in game loading screen. 
        /// (Legal values: CHALLENGER, MASTER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE, UNRANKED)
        /// </summary>
        [DataMember(Name = "highestAchievedSeasonTier")]
        public Helpers.Enums.HighestAchievedSeasonTier HighestAchievedSeasonTier { get; set; }

        /// <summary>
        /// List of mastery information
        /// </summary>
        [DataMember(Name = "masteries")]
        public IEnumerable<Mastery> Masteries { get; set; }

        /// <summary>
        /// Participant ID
        /// </summary>
        [DataMember(Name = "participantId")]
        public int ParticipantId { get; set; }

        /// <summary>
        /// List of rune information
        /// </summary>
        [DataMember(Name = "runes")]
        public IEnumerable<Rune> Runes { get; set; }

        /// <summary>
        /// First summoner spell ID
        /// </summary>
        [DataMember(Name = "spell1Id")]
        public int Spell1Id { get; set; }

        /// <summary>
        /// Second summoner spell ID
        /// </summary>
        [DataMember(Name = "spell2Id")]
        public int Spell2Id { get; set; }

        /// <summary>
        /// Participant statistics
        /// </summary>
        [DataMember(Name = "stats")]
        public ParticipantStats Stats { get; set; }

        /// <summary>
        /// Team ID
        /// </summary>
        [DataMember(Name = "teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Timeline data. Delta fields refer to values for the specified period 
        /// (e.g., the gold per minute over the first 10 minutes of the game versus the second 20 minutes of the game. 
        /// Diffs fields refer to the deltas versus the calculated lane opponent(s).
        /// </summary>
        [DataMember(Name = "timeline")]
        public ParticipantTimeline Timeline { get; set; }
    }
}

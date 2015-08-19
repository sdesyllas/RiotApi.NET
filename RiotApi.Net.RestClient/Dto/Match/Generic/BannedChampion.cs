using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains information about banned champions
    /// </summary>
    [DataContract]
    public class BannedChampion
    {
        /// <summary>
        /// Banned champion ID
        /// </summary>
        [DataMember(Name = "championId")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Turn during which the champion was banned
        /// </summary>
        [DataMember(Name = "pickTurn")]
        public int PickTurn { get; set; }
    }
}

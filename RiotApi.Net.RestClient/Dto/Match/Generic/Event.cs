using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace RiotApi.Net.RestClient.Dto.Match.Generic
{
    /// <summary>
    /// This object contains game event information. Note that not all legal type values documented below are valid for all games. 
    /// Event data evolves over time and certain values may be relevant only for older or newer games.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// The ascended type of the event. 
        /// Only present if relevant. Note that CLEAR_ASCENDED refers to when a participants kills the ascended player. 
        /// (Legal values: CHAMPION_ASCENDED, CLEAR_ASCENDED, MINION_ASCENDED)
        /// </summary>
        [JsonProperty(PropertyName = "ascendedType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.AscendedType AscendedType { get; set; }

        /// <summary>
        /// The assisting participant IDs of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "assistingParticipantIds")]
        public IEnumerable<int> AssistingParticipantIds { get; set; }

        /// <summary>
        /// The building type of the event. Only present if relevant. (Legal values: INHIBITOR_BUILDING, TOWER_BUILDING)
        /// </summary>
        [JsonProperty(PropertyName = "buildingType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.BuildingType BuildingType { get; set; }

        /// <summary>
        /// The creator ID of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "creatorId")]
        public int CreatorId { get; set; }

        /// <summary>
        /// Event type. 
        /// (Legal values: ASCENDED_EVENT, BUILDING_KILL, CAPTURE_POINT, CHAMPION_KILL, ELITE_MONSTER_KILL, ITEM_DESTROYED, 
        /// ITEM_PURCHASED, ITEM_SOLD, ITEM_UNDO, PORO_KING_SUMMON, SKILL_LEVEL_UP, WARD_KILL, WARD_PLACED)
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.EventType EventType { get; set; }

        /// <summary>
        /// The ending item ID of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "itemAfter")]
        public int ItemAfter { get; set; }

        /// <summary>
        /// The starting item ID of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "itemBefore")]
        public int ItemBefore { get; set; }

        /// <summary>
        /// The item ID of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "itemId")]
        public int ItemId { get; set; }

        /// <summary>
        /// The killer ID of the event. Only present if relevant. Killer ID 0 indicates a minion.
        /// </summary>
        [JsonProperty(PropertyName = "killerId")]
        public int KillerId { get; set; }

        /// <summary>
        /// The lane type of the event. Only present if relevant. (Legal values: BOT_LANE, MID_LANE, TOP_LANE)
        /// </summary>
        [JsonProperty(PropertyName = "laneType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.LaneType LaneType { get; set; }

        /// <summary>
        /// The level up type of the event. Only present if relevant. (Legal values: EVOLVE, NORMAL)
        /// </summary>
        [JsonProperty(PropertyName = "levelUpType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.LevelUpType LevelUpType { get; set; }

        /// <summary>
        /// The monster type of the event. Only present if relevant. 
        /// (Legal values: BARON_NASHOR, BLUE_GOLEM, DRAGON, RED_LIZARD, VILEMAW)
        /// </summary>
        [JsonProperty(PropertyName = "monsterType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.MonsterType MonsterType { get; set; }

        /// <summary>
        /// The participant ID of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "participantId")]
        public int ParticipantId { get; set; }

        /// <summary>
        /// The point captured in the event. Only present if relevant. (Legal values: POINT_A, POINT_B, POINT_C, POINT_D, POINT_E)
        /// </summary>
        [JsonProperty(PropertyName = "pointCaptured")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.PointCaptured PointCaptured { get; set; }

        /// <summary>
        /// The position of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }

        /// <summary>
        /// The skill slot of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "skillSlot")]
        public int SkillSlot { get; set; }

        /// <summary>
        /// The team ID of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "teamId")]
        public int TeamId { get; set; }

        /// <summary>
        /// Represents how many milliseconds into the game the event occurred.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// The tower type of the event. Only present if relevant. 
        /// (Legal values: BASE_TURRET, FOUNTAIN_TURRET, INNER_TURRET, NEXUS_TURRET, OUTER_TURRET, UNDEFINED_TURRET)
        /// </summary>
        [JsonProperty(PropertyName = "towerType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.TowerType TowerType { get; set; }

        /// <summary>
        /// The victim ID of the event. Only present if relevant.
        /// </summary>
        [JsonProperty(PropertyName = "victimId")]
        public int VictimId { get; set; }

        /// <summary>
        /// The ward type of the event. Only present if relevant. 
        /// (Legal values: SIGHT_WARD, TEEMO_MUSHROOM, UNDEFINED, VISION_WARD, YELLOW_TRINKET, YELLOW_TRINKET_UPGRADE)
        /// </summary>
        [JsonProperty(PropertyName = "wardType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Helpers.Enums.WardType WardType { get; set; }
    }
}

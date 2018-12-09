using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryEvent
    {
        [JsonProperty("assistingParticipantIds")]
        public int[] AssistingParticipantIds { get; set; }
        [JsonProperty("buildingType")]
        public string BuildingType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("killerId")]
        public int KillerId { get; set; }
        [JsonProperty("laneType")]
        public string LaneType { get; set; }
        [JsonProperty("monsterSubType")]
        public string MonsterSubType { get; set; }
        [JsonProperty("monsterType")]
        public string MonsterType { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("position")]
        public LolMatchHistoryMatchHistoryPosition Position { get; set; }
        [JsonProperty("skillSlot")]
        public int SkillSlot { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        [JsonProperty("towerType")]
        public string TowerType { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("victimId")]
        public int VictimId { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerMissionObjectiveDTO
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("hasObjectiveBasedReward")]
        public bool HasObjectiveBasedReward { get; set; }
        [JsonProperty("progress")]
        public MissionProgressDTO Progress { get; set; }
        [JsonProperty("rewardGroups")]
        public string[] RewardGroups { get; set; }
        [JsonProperty("sequence")]
        public int Sequence { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

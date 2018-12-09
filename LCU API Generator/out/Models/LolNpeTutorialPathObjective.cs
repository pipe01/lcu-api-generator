using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathObjective
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("progress")]
        public LolNpeTutorialPathProgress Progress { get; set; }
        [JsonProperty("rewardGroups")]
        public string[] RewardGroups { get; set; }
        [JsonProperty("sequence")]
        public int Sequence { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathTutorialReward
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }
        [JsonProperty("itemId")]
        public string ItemId { get; set; }
        [JsonProperty("rewardFulfilled")]
        public bool RewardFulfilled { get; set; }
        [JsonProperty("rewardType")]
        public string RewardType { get; set; }
        [JsonProperty("sequence")]
        public int Sequence { get; set; }
        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }
    }
}

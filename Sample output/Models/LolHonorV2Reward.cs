using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2Reward
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("rewardType")]
        public string RewardType { get; set; }
    }
}

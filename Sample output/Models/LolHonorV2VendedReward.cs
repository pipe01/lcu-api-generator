using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2VendedReward
    {
        [JsonProperty("dynamicHonorMessage")]
        public LolHonorV2DynamicHonorMessage DynamicHonorMessage { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("rewardType")]
        public string RewardType { get; set; }
    }
}

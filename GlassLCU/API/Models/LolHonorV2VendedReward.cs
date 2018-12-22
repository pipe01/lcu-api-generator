using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

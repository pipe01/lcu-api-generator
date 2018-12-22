using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryLoyaltyStatusNotification
    {
        [JsonProperty("rewards")]
        public LolInventoryLoyaltyRewards Rewards { get; set; }
        [JsonProperty("status")]
        public LolInventoryLoyaltyStatus Status { get; set; }
    }
}

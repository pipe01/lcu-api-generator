using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoyaltyLoyaltyStatusNotification
    {
        [JsonProperty("rewards")]
        public LolLoyaltyLoyaltyRewards Rewards { get; set; }
        [JsonProperty("status")]
        public LolLoyaltyLoyaltyStatus Status { get; set; }
    }
}

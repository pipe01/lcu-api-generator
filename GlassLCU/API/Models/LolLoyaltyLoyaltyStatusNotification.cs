using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

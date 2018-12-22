using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerMissionEligibilityData
    {
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("loyaltyEnabled")]
        public bool LoyaltyEnabled { get; set; }
        [JsonProperty("playerInventory")]
        public PlayerInventory PlayerInventory { get; set; }
    }
}

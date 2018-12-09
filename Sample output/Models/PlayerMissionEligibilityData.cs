using Newtonsoft.Json;

namespace LCU_API_Generator
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

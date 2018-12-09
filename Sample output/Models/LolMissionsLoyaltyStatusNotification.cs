using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMissionsLoyaltyStatusNotification
    {
        [JsonProperty("status")]
        public LolMissionsLoyaltyStatus Status { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMissionsLoyaltyStatusNotification
    {
        [JsonProperty("status")]
        public LolMissionsLoyaltyStatus Status { get; set; }
    }
}

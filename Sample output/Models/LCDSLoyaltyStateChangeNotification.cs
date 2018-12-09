using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LCDSLoyaltyStateChangeNotification
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("notificationCategory")]
        public LCDSLoyaltyStateChangeNotificationCategory NotificationCategory { get; set; }
        [JsonProperty("rewards")]
        public LCDSLoyaltyRewards Rewards { get; set; }
    }
}

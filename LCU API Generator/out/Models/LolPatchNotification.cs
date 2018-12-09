using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPatchNotification
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("notificationId")]
        public LolPatchNotificationId NotificationId { get; set; }
    }
}

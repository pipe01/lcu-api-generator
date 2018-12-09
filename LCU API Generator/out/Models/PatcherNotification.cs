using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PatcherNotification
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("notificationId")]
        public PatcherNotificationId NotificationId { get; set; }
    }
}

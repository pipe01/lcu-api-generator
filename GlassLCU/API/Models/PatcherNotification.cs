using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

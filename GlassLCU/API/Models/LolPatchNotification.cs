using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

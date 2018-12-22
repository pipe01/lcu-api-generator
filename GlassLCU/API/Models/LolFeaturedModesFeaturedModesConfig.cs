using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolFeaturedModesFeaturedModesConfig
    {
        [JsonProperty("MaxNotificationSaveDelayMinutes")]
        public int MaxNotificationSaveDelayMinutes { get; set; }
        [JsonProperty("NotificationsEnabled")]
        public bool NotificationsEnabled { get; set; }
        [JsonProperty("QueueToggleNotificationMinutesThreshold")]
        public int QueueToggleNotificationMinutesThreshold { get; set; }
    }
}

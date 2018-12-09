using Newtonsoft.Json;

namespace LCU_API_Generator
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

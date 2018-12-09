using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerNotificationsPlayerNotificationConfigResource
    {
        [JsonProperty("ExpirationCheckFrequency")]
        public long ExpirationCheckFrequency { get; set; }
    }
}

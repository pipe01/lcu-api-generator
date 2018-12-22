using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerNotificationsPlayerNotificationConfigResource
    {
        [JsonProperty("ExpirationCheckFrequency")]
        public long ExpirationCheckFrequency { get; set; }
    }
}

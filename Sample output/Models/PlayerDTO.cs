using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerDTO
    {
        [JsonProperty("banned")]
        public bool Banned { get; set; }
        [JsonProperty("notifications")]
        public ClashOfflineNotification[] Notifications { get; set; }
    }
}

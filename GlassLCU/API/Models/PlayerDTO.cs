using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

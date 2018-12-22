using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolServiceStatusLoginDataPacket
    {
        [JsonProperty("broadcastNotification")]
        public LolServiceStatusBroadcastNotification BroadcastNotification { get; set; }
    }
}

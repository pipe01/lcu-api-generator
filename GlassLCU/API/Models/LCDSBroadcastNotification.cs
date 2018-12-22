using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LCDSBroadcastNotification
    {
        [JsonProperty("broadcastMessages")]
        public object[] BroadcastMessages { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolServiceStatusBroadcastNotification
    {
        [JsonProperty("broadcastMessages")]
        public object[] BroadcastMessages { get; set; }
    }
}
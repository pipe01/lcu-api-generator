using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LCDSBroadcastNotification
    {
        [JsonProperty("broadcastMessages")]
        public object[] BroadcastMessages { get; set; }
    }
}

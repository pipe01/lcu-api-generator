using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolServiceStatusLoginDataPacket
    {
        [JsonProperty("broadcastNotification")]
        public LolServiceStatusBroadcastNotification BroadcastNotification { get; set; }
    }
}

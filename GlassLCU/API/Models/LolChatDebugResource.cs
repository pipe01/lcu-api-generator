using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatDebugResource
    {
        [JsonProperty("asyncWaitInterval")]
        public int AsyncWaitInterval { get; set; }
        [JsonProperty("enableChatFiltering")]
        public bool EnableChatFiltering { get; set; }
        [JsonProperty("failAllChatLogin")]
        public bool FailAllChatLogin { get; set; }
        [JsonProperty("failNextChatLogin")]
        public bool FailNextChatLogin { get; set; }
        [JsonProperty("failNextChatLogout")]
        public bool FailNextChatLogout { get; set; }
        [JsonProperty("failNextKeepAlive")]
        public bool FailNextKeepAlive { get; set; }
        [JsonProperty("isXMPPLoggingEnabled")]
        public bool IsXMPPLoggingEnabled { get; set; }
        [JsonProperty("keepAliveInterval")]
        public int KeepAliveInterval { get; set; }
        [JsonProperty("maxReconnectInterval")]
        public int MaxReconnectInterval { get; set; }
        [JsonProperty("minReconnectInterval")]
        public int MinReconnectInterval { get; set; }
        [JsonProperty("silenceChatWhileInGame")]
        public bool SilenceChatWhileInGame { get; set; }
        [JsonProperty("triggerChatDisconnect")]
        public bool TriggerChatDisconnect { get; set; }
    }
}

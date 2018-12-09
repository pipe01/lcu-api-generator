using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerBehaviorReformCardChatLogs
    {
        [JsonProperty("inGameChatLogs")]
        public string[] InGameChatLogs { get; set; }
        [JsonProperty("postGameChatLogs")]
        public string[] PostGameChatLogs { get; set; }
        [JsonProperty("preGameChatLogs")]
        public string[] PreGameChatLogs { get; set; }
    }
}

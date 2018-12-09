using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatPlayerPreferences
    {
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("hash")]
        public string Hash { get; set; }
        [JsonProperty("modified")]
        public long Modified { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
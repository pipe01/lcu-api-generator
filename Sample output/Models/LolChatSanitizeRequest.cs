using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatSanitizeRequest
    {
        [JsonProperty("aggressiveScan")]
        public bool AggressiveScan { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("texts")]
        public string[] Texts { get; set; }
    }
}

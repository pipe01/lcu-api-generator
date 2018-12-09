using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatSanitizeResponse
    {
        [JsonProperty("modified")]
        public bool Modified { get; set; }
        [JsonProperty("texts")]
        public string[] Texts { get; set; }
    }
}

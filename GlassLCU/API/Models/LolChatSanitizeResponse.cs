using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

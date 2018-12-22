using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class SanitizerSanitizeResponse
    {
        [JsonProperty("modified")]
        public bool Modified { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("texts")]
        public string[] Texts { get; set; }
    }
}

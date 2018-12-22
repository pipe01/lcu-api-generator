using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class SanitizerSanitizeRequest
    {
        [JsonProperty("aggressiveScan")]
        public bool AggressiveScan { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("texts")]
        public string[] Texts { get; set; }
    }
}

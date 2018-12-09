using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class SanitizerContainsSanitizedRequest
    {
        [JsonProperty("aggressiveScan")]
        public bool AggressiveScan { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

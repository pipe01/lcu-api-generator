using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerPreferencesPlayerPreferences
    {
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("hash")]
        public string Hash { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}

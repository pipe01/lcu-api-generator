using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PluginResourceContract
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}

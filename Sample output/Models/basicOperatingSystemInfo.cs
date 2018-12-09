using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class basicOperatingSystemInfo
    {
        [JsonProperty("edition")]
        public string Edition { get; set; }
        [JsonProperty("platform")]
        public string Platform { get; set; }
        [JsonProperty("versionMajor")]
        public string VersionMajor { get; set; }
        [JsonProperty("versionMinor")]
        public string VersionMinor { get; set; }
    }
}

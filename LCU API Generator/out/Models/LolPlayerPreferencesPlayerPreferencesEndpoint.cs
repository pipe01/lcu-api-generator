using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerPreferencesPlayerPreferencesEndpoint
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("EnforceHttps")]
        public bool EnforceHttps { get; set; }
        [JsonProperty("Retries")]
        public long Retries { get; set; }
        [JsonProperty("ServiceEndpoint")]
        public string ServiceEndpoint { get; set; }
        [JsonProperty("Version")]
        public string Version { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class cookie
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }
        [JsonProperty("expires")]
        public long Expires { get; set; }
        [JsonProperty("httponly")]
        public bool Httponly { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("secure")]
        public bool Secure { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

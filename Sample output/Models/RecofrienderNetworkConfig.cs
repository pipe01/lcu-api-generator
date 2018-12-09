using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderNetworkConfig
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("linkUrlTemplate")]
        public string LinkUrlTemplate { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("unlinkUrlTemplate")]
        public string UnlinkUrlTemplate { get; set; }
    }
}

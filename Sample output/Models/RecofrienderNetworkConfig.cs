//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

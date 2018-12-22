using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ClientDynamicConfig
    {
        [JsonProperty("compressed")]
        public bool Compressed { get; set; }
        [JsonProperty("configs")]
        public string Configs { get; set; }
        [JsonProperty("delta")]
        public bool Delta { get; set; }
    }
}

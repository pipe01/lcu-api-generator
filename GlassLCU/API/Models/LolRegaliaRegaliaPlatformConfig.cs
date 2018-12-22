using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaRegaliaPlatformConfig
    {
        [JsonProperty("HovercardEnabled")]
        public bool HovercardEnabled { get; set; }
        [JsonProperty("SelectionsEnabled")]
        public bool SelectionsEnabled { get; set; }
    }
}

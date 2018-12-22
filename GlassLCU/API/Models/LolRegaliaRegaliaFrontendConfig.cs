using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaRegaliaFrontendConfig
    {
        [JsonProperty("hovercardEnabled")]
        public bool HovercardEnabled { get; set; }
        [JsonProperty("selectionsEnabled")]
        public bool SelectionsEnabled { get; set; }
    }
}

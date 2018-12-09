using Newtonsoft.Json;

namespace LCU_API_Generator
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

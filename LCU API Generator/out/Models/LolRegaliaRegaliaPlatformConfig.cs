using Newtonsoft.Json;

namespace LCU_API_Generator
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

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksPlatformConfig
    {
        [JsonProperty("AutoRepairPagesEnabled")]
        public bool AutoRepairPagesEnabled { get; set; }
        [JsonProperty("PerksEnabled")]
        public bool PerksEnabled { get; set; }
    }
}

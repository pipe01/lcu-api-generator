//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

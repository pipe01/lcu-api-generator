using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksPerkSettings
    {
        [JsonProperty("pages")]
        public LolPerksPerkPageResource[] Pages { get; set; }
        [JsonProperty("perShardPerkBooks")]
        public object PerShardPerkBooks { get; set; }
        [JsonProperty("settings")]
        public LolPerksUISettings Settings { get; set; }
    }
}

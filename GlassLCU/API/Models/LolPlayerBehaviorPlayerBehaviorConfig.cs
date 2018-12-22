using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerBehaviorPlayerBehaviorConfig
    {
        [JsonProperty("IsLoaded")]
        public bool IsLoaded { get; set; }
        [JsonProperty("ReformCardV2Enabled")]
        public bool ReformCardV2Enabled { get; set; }
    }
}

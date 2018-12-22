using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ClashRewardConfigEntry
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("vals")]
        public ClashRewardOutput[] Vals { get; set; }
    }
}

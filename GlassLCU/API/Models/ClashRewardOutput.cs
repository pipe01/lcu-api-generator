using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ClashRewardOutput
    {
        [JsonProperty("alternative")]
        public ClashRewardDefinition Alternative { get; set; }
        [JsonProperty("grant")]
        public ClashRewardTime Grant { get; set; }
        [JsonProperty("primary")]
        public ClashRewardDefinition Primary { get; set; }
        [JsonProperty("show")]
        public ClashRewardTime Show { get; set; }
    }
}
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RewardStrategy
    {
        [JsonProperty("groupStrategy")]
        public string GroupStrategy { get; set; }
        [JsonProperty("selectMaxGroupCount")]
        public int SelectMaxGroupCount { get; set; }
        [JsonProperty("selectMinGroupCount")]
        public int SelectMinGroupCount { get; set; }
    }
}

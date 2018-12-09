using Newtonsoft.Json;

namespace LCU_API_Generator
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

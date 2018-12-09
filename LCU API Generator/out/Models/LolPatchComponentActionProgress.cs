using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPatchComponentActionProgress
    {
        [JsonProperty("currentItem")]
        public string CurrentItem { get; set; }
        [JsonProperty("network")]
        public LolPatchComponentStateProgress Network { get; set; }
        [JsonProperty("primaryWork")]
        public LolPatchComponentStateWorkType PrimaryWork { get; set; }
        [JsonProperty("total")]
        public LolPatchComponentStateProgress Total { get; set; }
    }
}

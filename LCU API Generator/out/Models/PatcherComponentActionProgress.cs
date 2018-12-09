using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PatcherComponentActionProgress
    {
        [JsonProperty("currentItem")]
        public string CurrentItem { get; set; }
        [JsonProperty("network")]
        public PatcherComponentStateProgress Network { get; set; }
        [JsonProperty("primaryWork")]
        public PatcherComponentStateWorkType PrimaryWork { get; set; }
        [JsonProperty("total")]
        public PatcherComponentStateProgress Total { get; set; }
    }
}

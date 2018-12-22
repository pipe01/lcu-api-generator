using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PatcherP2PStatus
    {
        [JsonProperty("isAllowedByUser")]
        public bool IsAllowedByUser { get; set; }
        [JsonProperty("isEnabledForPatchline")]
        public bool IsEnabledForPatchline { get; set; }
        [JsonProperty("requiresRestart")]
        public bool RequiresRestart { get; set; }
    }
}

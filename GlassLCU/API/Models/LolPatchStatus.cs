using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPatchStatus
    {
        [JsonProperty("connectedToPatchServer")]
        public bool ConnectedToPatchServer { get; set; }
        [JsonProperty("hasUpdatesOnRestart")]
        public bool HasUpdatesOnRestart { get; set; }
        [JsonProperty("willRestartOnSelfUpdate")]
        public bool WillRestartOnSelfUpdate { get; set; }
    }
}

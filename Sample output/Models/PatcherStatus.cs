//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PatcherStatus
    {
        [JsonProperty("connectedToPatchServer")]
        public bool ConnectedToPatchServer { get; set; }
        [JsonProperty("hasUpdatesOnRestart")]
        public bool HasUpdatesOnRestart { get; set; }
        [JsonProperty("successfullyInstalledVersion")]
        public int SuccessfullyInstalledVersion { get; set; }
        [JsonProperty("willRestartOnSelfUpdate")]
        public bool WillRestartOnSelfUpdate { get; set; }
    }
}

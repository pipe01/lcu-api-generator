using Newtonsoft.Json;

namespace LCU_API_Generator
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

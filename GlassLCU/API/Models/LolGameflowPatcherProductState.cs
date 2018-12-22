using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowPatcherProductState
    {
        [JsonProperty("action")]
        public LolGameflowPatcherProductStateAction Action { get; set; }
        [JsonProperty("isCorrupted")]
        public bool IsCorrupted { get; set; }
        [JsonProperty("isStopped")]
        public bool IsStopped { get; set; }
        [JsonProperty("isUpToDate")]
        public bool IsUpToDate { get; set; }
        [JsonProperty("isUpdateAvailable")]
        public bool IsUpdateAvailable { get; set; }
    }
}

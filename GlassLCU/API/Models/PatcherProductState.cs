using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PatcherProductState
    {
        [JsonProperty("action")]
        public PatcherComponentStateAction Action { get; set; }
        [JsonProperty("components")]
        public PatcherComponentState[] Components { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("isCorrupted")]
        public bool IsCorrupted { get; set; }
        [JsonProperty("isStopped")]
        public bool IsStopped { get; set; }
        [JsonProperty("isUpToDate")]
        public bool IsUpToDate { get; set; }
        [JsonProperty("isUpdateAvailable")]
        public bool IsUpdateAvailable { get; set; }
        [JsonProperty("percentPatched")]
        public float PercentPatched { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PatcherComponentState
    {
        [JsonProperty("action")]
        public PatcherComponentStateAction Action { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("isCorrupted")]
        public bool IsCorrupted { get; set; }
        [JsonProperty("isUpToDate")]
        public bool IsUpToDate { get; set; }
        [JsonProperty("isUpdateAvailable")]
        public bool IsUpdateAvailable { get; set; }
        [JsonProperty("progress")]
        public PatcherComponentActionProgress Progress { get; set; }
        [JsonProperty("timeOfLastUpToDateCheckISO8601")]
        public string TimeOfLastUpToDateCheckISO8601 { get; set; }
    }
}

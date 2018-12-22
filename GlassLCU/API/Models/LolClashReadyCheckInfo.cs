using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashReadyCheckInfo
    {
        [JsonProperty("acceptError")]
        public string AcceptError { get; set; }
        [JsonProperty("isAcceptSuccessful")]
        public bool IsAcceptSuccessful { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("readyCheckResource")]
        public LolClashMatchmakingReadyCheckResource ReadyCheckResource { get; set; }
        [JsonProperty("timestampLastClashGameflowDodge")]
        public long TimestampLastClashGameflowDodge { get; set; }
        [JsonProperty("timestampReceived")]
        public long TimestampReceived { get; set; }
        [JsonProperty("timestampResponseComplete")]
        public long TimestampResponseComplete { get; set; }
    }
}

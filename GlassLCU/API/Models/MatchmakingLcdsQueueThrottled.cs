using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MatchmakingLcdsQueueThrottled
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("reasonFailed")]
        public string ReasonFailed { get; set; }
        [JsonProperty("summoner")]
        public MatchmakingLcdsSummoner Summoner { get; set; }
    }
}

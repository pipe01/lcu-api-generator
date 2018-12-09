using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MatchmakingLcdsQueueDisabled
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

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoginLoginQueue
    {
        [JsonProperty("approximateWaitTimeSeconds")]
        public long ApproximateWaitTimeSeconds { get; set; }
        [JsonProperty("estimatedPositionInQueue")]
        public long EstimatedPositionInQueue { get; set; }
        [JsonProperty("isPositionCapped")]
        public bool IsPositionCapped { get; set; }
    }
}

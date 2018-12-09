using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class QueueEligilibilityGatekeeperRestrictionDtoV3
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("remainingMillis")]
        public long RemainingMillis { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}

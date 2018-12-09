using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLeaverBusterMatchmakingSearchErrorResource
    {
        [JsonProperty("errorType")]
        public string ErrorType { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("penalizedSummonerId")]
        public long PenalizedSummonerId { get; set; }
        [JsonProperty("penaltyTimeRemaining")]
        public float PenaltyTimeRemaining { get; set; }
    }
}

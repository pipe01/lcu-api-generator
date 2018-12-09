using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSummonerAutoFillQueueDto
    {
        [JsonProperty("autoFillEligible")]
        public bool AutoFillEligible { get; set; }
        [JsonProperty("autoFillProtectedForPromos")]
        public bool AutoFillProtectedForPromos { get; set; }
        [JsonProperty("autoFillProtectedForStreaking")]
        public bool AutoFillProtectedForStreaking { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

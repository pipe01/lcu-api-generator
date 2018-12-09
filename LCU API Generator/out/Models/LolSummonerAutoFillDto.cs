using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSummonerAutoFillDto
    {
        [JsonProperty("autoFillQueues")]
        public LolSummonerAutoFillQueueDto[] AutoFillQueues { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSummonerAutoFillDto
    {
        [JsonProperty("autoFillQueues")]
        public LolSummonerAutoFillQueueDto[] AutoFillQueues { get; set; }
    }
}

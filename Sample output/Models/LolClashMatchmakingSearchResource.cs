using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashMatchmakingSearchResource
    {
        [JsonProperty("dodgeData")]
        public LolClashMatchmakingDodgeData DodgeData { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("readyCheck")]
        public LolClashMatchmakingReadyCheckResource ReadyCheck { get; set; }
    }
}

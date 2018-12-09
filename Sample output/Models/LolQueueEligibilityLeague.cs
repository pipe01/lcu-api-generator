using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilityLeague
    {
        [JsonProperty("leagueTier")]
        public string LeagueTier { get; set; }
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
    }
}

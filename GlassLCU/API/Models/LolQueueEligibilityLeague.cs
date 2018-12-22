using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

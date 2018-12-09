using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilityQueueShutdownStatus
    {
        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }
    }
}

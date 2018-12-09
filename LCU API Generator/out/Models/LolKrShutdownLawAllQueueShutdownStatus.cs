using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolKrShutdownLawAllQueueShutdownStatus
    {
        [JsonProperty("isAllQueuesDisabled")]
        public bool IsAllQueuesDisabled { get; set; }
    }
}

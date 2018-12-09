using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolKrShutdownLawQueueShutdownStatus
    {
        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilityCollectionsChampion
    {
        [JsonProperty("disabledQueues")]
        public string[] DisabledQueues { get; set; }
        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }
        [JsonProperty("ownership")]
        public LolQueueEligibilityCollectionsOwnership Ownership { get; set; }
        [JsonProperty("purchased")]
        public long Purchased { get; set; }
        [JsonProperty("rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

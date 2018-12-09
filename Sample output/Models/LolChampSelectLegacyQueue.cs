using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyQueue
    {
        [JsonProperty("areFreeChampionsAllowed")]
        public bool AreFreeChampionsAllowed { get; set; }
        [JsonProperty("gameTypeConfig")]
        public LolChampSelectLegacyQueueGameTypeConfig GameTypeConfig { get; set; }
    }
}

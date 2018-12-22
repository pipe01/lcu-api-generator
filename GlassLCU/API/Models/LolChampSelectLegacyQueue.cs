using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

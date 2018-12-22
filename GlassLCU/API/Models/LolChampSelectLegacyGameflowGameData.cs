using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectLegacyGameflowGameData
    {
        [JsonProperty("queue")]
        public LolChampSelectLegacyQueue Queue { get; set; }
    }
}

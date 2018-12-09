using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyGameflowGameData
    {
        [JsonProperty("queue")]
        public LolChampSelectLegacyQueue Queue { get; set; }
    }
}

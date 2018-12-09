using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedStatsPluginStatus
    {
        [JsonProperty("ready")]
        public bool Ready { get; set; }
    }
}

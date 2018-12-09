using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedGameflowGameData
    {
        [JsonProperty("queue")]
        public LolRankedQueue Queue { get; set; }
    }
}

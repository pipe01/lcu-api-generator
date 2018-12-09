using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoadoutsGameflowGameData
    {
        [JsonProperty("queue")]
        public LolLoadoutsQueue Queue { get; set; }
    }
}

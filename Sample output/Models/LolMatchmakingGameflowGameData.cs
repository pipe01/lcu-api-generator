using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchmakingGameflowGameData
    {
        [JsonProperty("queue")]
        public LolMatchmakingGameflowQueue Queue { get; set; }
    }
}

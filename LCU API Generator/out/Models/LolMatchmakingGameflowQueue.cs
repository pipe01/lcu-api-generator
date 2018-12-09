using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchmakingGameflowQueue
    {
        [JsonProperty("gameTypeConfig")]
        public LolMatchmakingGameflowGameTypeConfig GameTypeConfig { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchmakingGameflowGameTypeConfig
    {
        [JsonProperty("reroll")]
        public bool Reroll { get; set; }
    }
}

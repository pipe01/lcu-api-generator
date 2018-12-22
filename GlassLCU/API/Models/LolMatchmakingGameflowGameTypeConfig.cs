using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchmakingGameflowGameTypeConfig
    {
        [JsonProperty("reroll")]
        public bool Reroll { get; set; }
    }
}

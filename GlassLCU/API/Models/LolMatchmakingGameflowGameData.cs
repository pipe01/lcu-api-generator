using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchmakingGameflowGameData
    {
        [JsonProperty("queue")]
        public LolMatchmakingGameflowQueue Queue { get; set; }
    }
}

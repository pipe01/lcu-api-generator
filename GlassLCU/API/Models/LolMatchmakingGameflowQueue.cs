using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchmakingGameflowQueue
    {
        [JsonProperty("gameTypeConfig")]
        public LolMatchmakingGameflowGameTypeConfig GameTypeConfig { get; set; }
    }
}

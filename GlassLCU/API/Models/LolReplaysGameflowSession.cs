using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolReplaysGameflowSession
    {
        [JsonProperty("gameClient")]
        public LolReplaysGameflowGameClient GameClient { get; set; }
        [JsonProperty("phase")]
        public LolReplaysGameflowPhase Phase { get; set; }
    }
}

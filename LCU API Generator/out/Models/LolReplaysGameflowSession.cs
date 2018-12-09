using Newtonsoft.Json;

namespace LCU_API_Generator
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

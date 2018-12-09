using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceGameflowSession
    {
        [JsonProperty("gameClient")]
        public LolPremadeVoiceGameflowGameClient GameClient { get; set; }
        [JsonProperty("phase")]
        public LolPremadeVoiceGameflowPhase Phase { get; set; }
    }
}

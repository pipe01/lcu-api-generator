using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

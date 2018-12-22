using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowGameflowGameDodge
    {
        [JsonProperty("dodgeIds")]
        public long[] DodgeIds { get; set; }
        [JsonProperty("phase")]
        public LolGameflowGameflowPhase Phase { get; set; }
        [JsonProperty("state")]
        public LolGameflowGameflowGameDodgeState State { get; set; }
    }
}

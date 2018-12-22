using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchmakingMatchmakingDodgeData
    {
        [JsonProperty("dodgerId")]
        public long DodgerId { get; set; }
        [JsonProperty("state")]
        public LolMatchmakingMatchmakingDodgeState State { get; set; }
    }
}

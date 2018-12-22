using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashMatchmakingDodgeData
    {
        [JsonProperty("dodgerId")]
        public long DodgerId { get; set; }
        [JsonProperty("state")]
        public LolClashMatchmakingDodgeState State { get; set; }
    }
}

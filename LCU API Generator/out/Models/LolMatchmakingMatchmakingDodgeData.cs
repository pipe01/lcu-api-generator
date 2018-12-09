using Newtonsoft.Json;

namespace LCU_API_Generator
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

using Newtonsoft.Json;

namespace LCU_API_Generator
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

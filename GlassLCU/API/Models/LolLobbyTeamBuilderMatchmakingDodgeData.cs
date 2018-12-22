using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderMatchmakingDodgeData
    {
        [JsonProperty("dodgerId")]
        public long DodgerId { get; set; }
        [JsonProperty("state")]
        public LolLobbyTeamBuilderMatchmakingDodgeState State { get; set; }
    }
}

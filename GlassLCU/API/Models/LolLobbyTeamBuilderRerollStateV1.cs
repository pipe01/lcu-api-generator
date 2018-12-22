using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderRerollStateV1
    {
        [JsonProperty("allowRerolling")]
        public bool AllowRerolling { get; set; }
        [JsonProperty("rerollsRemaining")]
        public int RerollsRemaining { get; set; }
    }
}

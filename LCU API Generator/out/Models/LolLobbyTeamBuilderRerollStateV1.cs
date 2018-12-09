using Newtonsoft.Json;

namespace LCU_API_Generator
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

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderCountdownTimer
    {
        [JsonProperty("counter")]
        public int Counter { get; set; }
        [JsonProperty("phaseName")]
        public string PhaseName { get; set; }
        [JsonProperty("timer")]
        public long Timer { get; set; }
    }
}
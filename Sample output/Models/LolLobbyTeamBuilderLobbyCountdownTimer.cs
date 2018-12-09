using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderLobbyCountdownTimer
    {
        [JsonProperty("counter")]
        public int Counter { get; set; }
        [JsonProperty("phaseName")]
        public string PhaseName { get; set; }
        [JsonProperty("timer")]
        public long Timer { get; set; }
    }
}

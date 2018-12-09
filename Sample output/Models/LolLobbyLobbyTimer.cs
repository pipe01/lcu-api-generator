using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyTimer
    {
        [JsonProperty("countdown")]
        public long Countdown { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}

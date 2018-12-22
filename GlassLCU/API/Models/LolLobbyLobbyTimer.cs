using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ProcessControlProcess
    {
        [JsonProperty("restart-countdown-seconds")]
        public float Restart_countdown_seconds { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyQueueCustomGame
    {
        [JsonProperty("queueAvailability")]
        public LolLobbyQueueAvailability QueueAvailability { get; set; }
    }
}

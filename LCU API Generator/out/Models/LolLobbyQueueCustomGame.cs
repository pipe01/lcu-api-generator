using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyQueueCustomGame
    {
        [JsonProperty("queueAvailability")]
        public LolLobbyQueueAvailability QueueAvailability { get; set; }
    }
}

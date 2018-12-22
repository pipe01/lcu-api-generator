using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyLastQueuedLobby
    {
        [JsonProperty("canPlayAgain")]
        public bool CanPlayAgain { get; set; }
        [JsonProperty("members")]
        public LolLobbyLobbyLastQueuedMember[] Members { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("wasOwner")]
        public bool WasOwner { get; set; }
    }
}
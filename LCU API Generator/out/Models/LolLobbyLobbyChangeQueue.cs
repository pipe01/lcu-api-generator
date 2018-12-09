using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyChangeQueue
    {
        [JsonProperty("customGameLobby")]
        public LolLobbyLobbyCustomGameLobby CustomGameLobby { get; set; }
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

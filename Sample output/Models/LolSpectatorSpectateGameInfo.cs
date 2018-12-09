using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSpectatorSpectateGameInfo
    {
        [JsonProperty("allowObserveMode")]
        public string AllowObserveMode { get; set; }
        [JsonProperty("dropInSpectateGameId")]
        public string DropInSpectateGameId { get; set; }
        [JsonProperty("gameQueueType")]
        public string GameQueueType { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathLobbyChangeQueue
    {
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

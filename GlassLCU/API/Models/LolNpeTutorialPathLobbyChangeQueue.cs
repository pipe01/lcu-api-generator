using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

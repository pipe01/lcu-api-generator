using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathLobbyGameConfigDto
    {
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

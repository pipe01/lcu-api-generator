using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathLobbyGameConfigDto
    {
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderCreatePremadeV1
    {
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

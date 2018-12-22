using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderCreatePremadeV1
    {
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

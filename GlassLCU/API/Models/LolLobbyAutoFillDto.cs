using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyAutoFillDto
    {
        [JsonProperty("autoFillQueues")]
        public LolLobbyAutoFillQueueDto[] AutoFillQueues { get; set; }
    }
}

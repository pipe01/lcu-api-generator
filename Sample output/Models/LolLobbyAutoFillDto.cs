//Auto-generated by https://github.com/pipe01/lcu-api-generator
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

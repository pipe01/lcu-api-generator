using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyAutoFillDto
    {
        [JsonProperty("autoFillQueues")]
        public LolLobbyAutoFillQueueDto[] AutoFillQueues { get; set; }
    }
}

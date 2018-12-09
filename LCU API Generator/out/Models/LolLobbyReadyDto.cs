using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyReadyDto
    {
        [JsonProperty("ready")]
        public bool Ready { get; set; }
    }
}

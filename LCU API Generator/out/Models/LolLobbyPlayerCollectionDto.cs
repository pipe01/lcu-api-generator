using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyPlayerCollectionDto
    {
        [JsonProperty("players")]
        public LolLobbyPlayerDto[] Players { get; set; }
    }
}

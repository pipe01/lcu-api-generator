using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}

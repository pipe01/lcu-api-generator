using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GameflowLcdsReconnectInfoDto
    {
        [JsonProperty("game")]
        public GameflowLcdsGameDTO Game { get; set; }
        [JsonProperty("playerCredentials")]
        public GameflowLcdsPlayerCredentialsDto PlayerCredentials { get; set; }
        [JsonProperty("reconnectDelay")]
        public int ReconnectDelay { get; set; }
    }
}

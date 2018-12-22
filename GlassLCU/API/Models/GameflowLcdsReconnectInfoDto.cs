using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

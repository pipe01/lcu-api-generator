using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowGameSessionReconnect
    {
        [JsonProperty("gameInfo")]
        public LolGameflowGameSessionGameInfo GameInfo { get; set; }
        [JsonProperty("playerReconnectInfo")]
        public LolGameflowGameSessionPlayerReconnectInfo PlayerReconnectInfo { get; set; }
    }
}

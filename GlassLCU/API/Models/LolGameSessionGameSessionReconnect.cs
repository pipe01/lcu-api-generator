using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameSessionGameSessionReconnect
    {
        [JsonProperty("gameInfo")]
        public LolGameSessionGameSessionGameInfo GameInfo { get; set; }
        [JsonProperty("playerReconnectInfo")]
        public LolGameSessionGameSessionPlayerReconnectInfo PlayerReconnectInfo { get; set; }
    }
}

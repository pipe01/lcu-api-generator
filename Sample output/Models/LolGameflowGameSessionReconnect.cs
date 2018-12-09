using Newtonsoft.Json;

namespace LCU_API_Generator
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

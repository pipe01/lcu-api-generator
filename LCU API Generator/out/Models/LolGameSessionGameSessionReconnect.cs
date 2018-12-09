using Newtonsoft.Json;

namespace LCU_API_Generator
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

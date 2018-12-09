using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameClientChatGameClientChatMessageResource
    {
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("fromSummonerName")]
        public string FromSummonerName { get; set; }
    }
}

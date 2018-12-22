using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
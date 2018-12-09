using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatSessionResource
    {
        [JsonProperty("sessionExpire")]
        public int SessionExpire { get; set; }
        [JsonProperty("sessionState")]
        public LolChatSessionState SessionState { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

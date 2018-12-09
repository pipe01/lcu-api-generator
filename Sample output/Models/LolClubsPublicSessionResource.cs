using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPublicSessionResource
    {
        [JsonProperty("sessionExpire")]
        public int SessionExpire { get; set; }
        [JsonProperty("sessionState")]
        public string SessionState { get; set; }
    }
}

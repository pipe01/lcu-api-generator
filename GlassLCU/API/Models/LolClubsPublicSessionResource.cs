using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RecofrienderSessionResource
    {
        [JsonProperty("sessionExpire")]
        public int SessionExpire { get; set; }
        [JsonProperty("sessionState")]
        public string SessionState { get; set; }
    }
}

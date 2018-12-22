using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class FailedInvite
    {
        [JsonProperty("exception")]
        public ClientRequestError Exception { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashClientFailedInvite
    {
        [JsonProperty("exception")]
        public string Exception { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}

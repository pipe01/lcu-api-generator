using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashKickRequest
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

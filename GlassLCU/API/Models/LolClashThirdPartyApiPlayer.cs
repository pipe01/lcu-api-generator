using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashThirdPartyApiPlayer
    {
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

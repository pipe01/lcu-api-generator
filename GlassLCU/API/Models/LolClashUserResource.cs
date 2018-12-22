using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashUserResource
    {
        [JsonProperty("lol")]
        public object Lol { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
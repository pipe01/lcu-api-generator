using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaLoginSession
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoginSummonerCreatedResource
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

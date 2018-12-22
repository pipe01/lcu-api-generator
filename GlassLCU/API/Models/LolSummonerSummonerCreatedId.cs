using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSummonerSummonerCreatedId
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

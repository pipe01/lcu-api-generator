//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSummonerSummonerIdAndName
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

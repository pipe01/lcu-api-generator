//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerLevelUpGameDataSummonerSpell
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}

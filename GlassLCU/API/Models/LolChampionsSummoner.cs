using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsSummoner
    {
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}

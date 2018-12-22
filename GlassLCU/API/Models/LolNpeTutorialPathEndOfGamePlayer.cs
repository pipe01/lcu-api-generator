using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathEndOfGamePlayer
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("stats")]
        public object Stats { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

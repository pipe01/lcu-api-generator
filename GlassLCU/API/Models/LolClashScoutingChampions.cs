using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashScoutingChampions
    {
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("topMasteries")]
        public LolClashScoutingChampionMastery[] TopMasteries { get; set; }
        [JsonProperty("topSeasonChampions")]
        public LolClashScoutingSeasonChampion[] TopSeasonChampions { get; set; }
        [JsonProperty("totalMasteryScore")]
        public long TotalMasteryScore { get; set; }
    }
}

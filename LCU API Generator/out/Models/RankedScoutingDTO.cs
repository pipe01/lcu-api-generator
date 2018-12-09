using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RankedScoutingDTO
    {
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("topMasteries")]
        public ChampionMasteryPublicDTO[] TopMasteries { get; set; }
        [JsonProperty("topSeasonChampions")]
        public ChampionScoutingDTO[] TopSeasonChampions { get; set; }
        [JsonProperty("totalMasteryScore")]
        public long TotalMasteryScore { get; set; }
    }
}

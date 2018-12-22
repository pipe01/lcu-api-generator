using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashRankedScoutingTopChampion
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameCount")]
        public int GameCount { get; set; }
        [JsonProperty("kda")]
        public string Kda { get; set; }
        [JsonProperty("kdaClassification")]
        public LolClashKdaClassification KdaClassification { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("winCount")]
        public int WinCount { get; set; }
        [JsonProperty("winRate")]
        public int WinRate { get; set; }
    }
}

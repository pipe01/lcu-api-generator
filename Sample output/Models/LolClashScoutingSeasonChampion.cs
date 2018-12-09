using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashScoutingSeasonChampion
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameCount")]
        public int GameCount { get; set; }
        [JsonProperty("kda")]
        public string Kda { get; set; }
        [JsonProperty("kdaClassification")]
        public LolClashKdaClassification KdaClassification { get; set; }
        [JsonProperty("winCount")]
        public int WinCount { get; set; }
        [JsonProperty("winRate")]
        public int WinRate { get; set; }
    }
}

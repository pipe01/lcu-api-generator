using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPftPFTEndOfGamePoints
    {
        [JsonProperty("pointChangeFromChampionsOwned")]
        public int PointChangeFromChampionsOwned { get; set; }
        [JsonProperty("pointChangeFromGameplay")]
        public int PointChangeFromGameplay { get; set; }
        [JsonProperty("pointsUntilNextReroll")]
        public int PointsUntilNextReroll { get; set; }
        [JsonProperty("pointsUsed")]
        public int PointsUsed { get; set; }
        [JsonProperty("previousPoints")]
        public int PreviousPoints { get; set; }
        [JsonProperty("rerollCount")]
        public int RerollCount { get; set; }
        [JsonProperty("totalPoints")]
        public int TotalPoints { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ChampSelectLcdsPointSummary
    {
        [JsonProperty("currentPoints")]
        public int CurrentPoints { get; set; }
        [JsonProperty("maxRolls")]
        public int MaxRolls { get; set; }
        [JsonProperty("numberOfRolls")]
        public int NumberOfRolls { get; set; }
        [JsonProperty("pointsCostToRoll")]
        public int PointsCostToRoll { get; set; }
        [JsonProperty("pointsToNextRoll")]
        public int PointsToNextRoll { get; set; }
    }
}

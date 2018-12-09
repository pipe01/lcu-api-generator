using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSummonerSummonerRerollPoints
    {
        [JsonProperty("currentPoints")]
        public long CurrentPoints { get; set; }
        [JsonProperty("maxRolls")]
        public int MaxRolls { get; set; }
        [JsonProperty("numberOfRolls")]
        public int NumberOfRolls { get; set; }
        [JsonProperty("pointsCostToRoll")]
        public long PointsCostToRoll { get; set; }
        [JsonProperty("pointsToReroll")]
        public long PointsToReroll { get; set; }
    }
}

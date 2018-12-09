using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameRerollDataBagForClientV1
    {
        [JsonProperty("maximumRerolls")]
        public int MaximumRerolls { get; set; }
        [JsonProperty("pointCostOfReroll")]
        public long PointCostOfReroll { get; set; }
        [JsonProperty("pointsGainedLastGame")]
        public long PointsGainedLastGame { get; set; }
        [JsonProperty("pointsUntilNextReroll")]
        public long PointsUntilNextReroll { get; set; }
        [JsonProperty("rerollCount")]
        public int RerollCount { get; set; }
        [JsonProperty("totalPoints")]
        public long TotalPoints { get; set; }
    }
}

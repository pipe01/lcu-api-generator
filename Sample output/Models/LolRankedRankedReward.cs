using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedRankedReward
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }
        [JsonProperty("pointsRequired")]
        public int PointsRequired { get; set; }
    }
}

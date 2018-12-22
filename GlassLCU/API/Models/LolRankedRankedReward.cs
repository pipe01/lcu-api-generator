using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

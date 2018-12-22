using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolContentTargetingRankedPositionInfo
    {
        [JsonProperty("division")]
        public LolContentTargetingRankedDivision Division { get; set; }
        [JsonProperty("isProvisional")]
        public bool IsProvisional { get; set; }
        [JsonProperty("tier")]
        public LolContentTargetingRankedTier Tier { get; set; }
    }
}

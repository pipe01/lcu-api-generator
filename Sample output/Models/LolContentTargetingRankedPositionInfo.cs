using Newtonsoft.Json;

namespace LCU_API_Generator
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

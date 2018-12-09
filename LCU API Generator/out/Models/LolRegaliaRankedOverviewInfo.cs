using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRegaliaRankedOverviewInfo
    {
        [JsonProperty("highestRankedEntry")]
        public LolRegaliaRankedPositionInfo HighestRankedEntry { get; set; }
    }
}

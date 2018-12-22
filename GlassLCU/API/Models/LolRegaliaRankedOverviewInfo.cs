using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaRankedOverviewInfo
    {
        [JsonProperty("highestRankedEntry")]
        public LolRegaliaRankedPositionInfo HighestRankedEntry { get; set; }
    }
}

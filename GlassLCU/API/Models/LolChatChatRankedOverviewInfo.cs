using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatChatRankedOverviewInfo
    {
        [JsonProperty("highestRankedEntry")]
        public LolChatChatRankedPositionInfo HighestRankedEntry { get; set; }
    }
}

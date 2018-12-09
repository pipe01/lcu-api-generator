using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatChatRankedOverviewInfo
    {
        [JsonProperty("highestRankedEntry")]
        public LolChatChatRankedPositionInfo HighestRankedEntry { get; set; }
    }
}

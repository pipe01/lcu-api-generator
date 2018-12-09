using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatChatRankedPositionInfo
    {
        [JsonProperty("division")]
        public LolChatChatRankedDivision Division { get; set; }
        [JsonProperty("games")]
        public long Games { get; set; }
        [JsonProperty("isProvisional")]
        public bool IsProvisional { get; set; }
        [JsonProperty("queueType")]
        public LolChatChatRankedQueue QueueType { get; set; }
        [JsonProperty("tier")]
        public LolChatChatRankedTier Tier { get; set; }
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerBehaviorPlayerBehavior_SimpleMessage
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("msgId")]
        public string MsgId { get; set; }
        [JsonProperty("params")]
        public string[] Params { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerMessagingSimpleMessage
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("bodyCode")]
        public string BodyCode { get; set; }
        [JsonProperty("msgId")]
        public string MsgId { get; set; }
        [JsonProperty("params")]
        public string[] Params { get; set; }
        [JsonProperty("titleCode")]
        public string TitleCode { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

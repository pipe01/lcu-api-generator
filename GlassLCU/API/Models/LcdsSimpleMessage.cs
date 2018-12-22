using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsSimpleMessage
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

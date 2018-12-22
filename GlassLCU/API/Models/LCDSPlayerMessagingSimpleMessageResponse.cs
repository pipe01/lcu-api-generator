using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LCDSPlayerMessagingSimpleMessageResponse
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("command")]
        public string Command { get; set; }
        [JsonProperty("msgId")]
        public string MsgId { get; set; }
    }
}

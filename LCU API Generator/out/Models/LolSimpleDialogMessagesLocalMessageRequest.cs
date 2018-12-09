using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSimpleDialogMessagesLocalMessageRequest
    {
        [JsonProperty("msgBody")]
        public string[] MsgBody { get; set; }
        [JsonProperty("msgType")]
        public string MsgType { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

//Auto-generated by https://github.com/pipe01/lcu-api-generator
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

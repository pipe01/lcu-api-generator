using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class SimpleDialogMessageResponse
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("command")]
        public string Command { get; set; }
        [JsonProperty("msgId")]
        public string MsgId { get; set; }
    }
}

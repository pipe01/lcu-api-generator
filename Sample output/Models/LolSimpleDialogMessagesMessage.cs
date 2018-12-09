using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSimpleDialogMessagesMessage
    {
        [JsonProperty("body")]
        public object Body { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

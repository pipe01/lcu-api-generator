using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

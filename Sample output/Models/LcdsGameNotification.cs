//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsGameNotification
    {
        [JsonProperty("messageArgument")]
        public string MessageArgument { get; set; }
        [JsonProperty("messageCode")]
        public string MessageCode { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

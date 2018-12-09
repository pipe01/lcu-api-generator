using Newtonsoft.Json;

namespace LCU_API_Generator
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

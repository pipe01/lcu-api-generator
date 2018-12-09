using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashRMSMessage
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}

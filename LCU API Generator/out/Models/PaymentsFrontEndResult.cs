using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PaymentsFrontEndResult
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

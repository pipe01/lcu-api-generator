using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PaymentsFrontEndResult
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolAccountVerificationSendTokenRequest
    {
        [JsonProperty("device")]
        public string Device { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("mediator")]
        public string Mediator { get; set; }
    }
}

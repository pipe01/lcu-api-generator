using Newtonsoft.Json;

namespace LCU_API_Generator
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

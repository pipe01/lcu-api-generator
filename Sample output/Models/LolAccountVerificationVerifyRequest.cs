using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolAccountVerificationVerifyRequest
    {
        [JsonProperty("mediator")]
        public string Mediator { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

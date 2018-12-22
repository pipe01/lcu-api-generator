using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

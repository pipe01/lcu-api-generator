using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEmailVerificationEmailVerificationSession
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("emailVerified")]
        public bool EmailVerified { get; set; }
        [JsonProperty("fatalError")]
        public bool FatalError { get; set; }
    }
}

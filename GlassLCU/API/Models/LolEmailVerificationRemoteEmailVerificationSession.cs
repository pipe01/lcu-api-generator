using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEmailVerificationRemoteEmailVerificationSession
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("emailVerified")]
        public bool EmailVerified { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEmailVerificationEmailUpdate
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}

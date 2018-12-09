using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoginPlatformGeneratedCredentials
    {
        [JsonProperty("gasToken")]
        public object GasToken { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}

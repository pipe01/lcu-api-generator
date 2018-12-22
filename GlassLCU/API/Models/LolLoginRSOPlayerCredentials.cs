using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoginRSOPlayerCredentials
    {
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolAccountVerificationAVSConfig
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("PasswordEnabled")]
        public bool PasswordEnabled { get; set; }
    }
}

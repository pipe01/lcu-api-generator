//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatPlayerPreferences
    {
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("hash")]
        public string Hash { get; set; }
        [JsonProperty("modified")]
        public long Modified { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

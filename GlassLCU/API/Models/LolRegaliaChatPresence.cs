using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaChatPresence
    {
        [JsonProperty("icon")]
        public int Icon { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("lol")]
        public LolRegaliaChatPresenceLolData Lol { get; set; }
    }
}

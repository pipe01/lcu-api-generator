using Newtonsoft.Json;

namespace LCU_API_Generator
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

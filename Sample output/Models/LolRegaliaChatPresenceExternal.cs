using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRegaliaChatPresenceExternal
    {
        [JsonProperty("icon")]
        public int Icon { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("lol")]
        public object Lol { get; set; }
    }
}

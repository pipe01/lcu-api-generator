using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashUserResource
    {
        [JsonProperty("lol")]
        public object Lol { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRegaliaLoginSession
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

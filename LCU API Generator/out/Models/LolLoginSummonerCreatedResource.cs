using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoginSummonerCreatedResource
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

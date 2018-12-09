using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSummonerSummonerIdAndName
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

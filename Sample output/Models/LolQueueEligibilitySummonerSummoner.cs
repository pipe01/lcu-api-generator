using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilitySummonerSummoner
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}

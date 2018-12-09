using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsInviter
    {
        [JsonProperty("previousSeasonHighestTier")]
        public string PreviousSeasonHighestTier { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}

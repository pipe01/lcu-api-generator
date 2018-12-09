using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolActiveBoostsEndOfGameStats
    {
        [JsonProperty("timeUntilNextFirstWinBonus")]
        public long TimeUntilNextFirstWinBonus { get; set; }
    }
}

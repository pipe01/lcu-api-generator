using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedEndOfGameStatsBlock
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
    }
}

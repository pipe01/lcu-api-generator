using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerLifetimeStats
    {
        [JsonProperty("playerStatSummaries")]
        public PlayerStatSummaries PlayerStatSummaries { get; set; }
    }
}

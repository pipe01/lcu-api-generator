using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeagueTierAndRankDTO
    {
        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }
        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
        [JsonProperty("rank")]
        public string Rank { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
    }
}

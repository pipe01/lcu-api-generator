using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolAcsAcsChampionGames
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("lane")]
        public string Lane { get; set; }
        [JsonProperty("queue")]
        public int Queue { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}

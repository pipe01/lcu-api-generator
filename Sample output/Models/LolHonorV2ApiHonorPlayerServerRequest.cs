using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2ApiHonorPlayerServerRequest
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("honorCategory")]
        public string HonorCategory { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

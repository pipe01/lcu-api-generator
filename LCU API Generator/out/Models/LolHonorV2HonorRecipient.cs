using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2HonorRecipient
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("honors")]
        public LolHonorV2Honor[] Honors { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

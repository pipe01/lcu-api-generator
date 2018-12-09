using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2MutualHonor
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("summoners")]
        public LolHonorV2MutualHonorPlayer[] Summoners { get; set; }
    }
}

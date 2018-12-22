using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

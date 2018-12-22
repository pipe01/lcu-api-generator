using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2ServiceProxyHonorPlayerServerRequest
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("honorType")]
        public string HonorType { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
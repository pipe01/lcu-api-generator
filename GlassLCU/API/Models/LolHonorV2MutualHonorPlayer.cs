using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2MutualHonorPlayer
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("skinIndex")]
        public int SkinIndex { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

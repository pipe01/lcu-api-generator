using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
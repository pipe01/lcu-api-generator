using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsCollectionsChampionSkinEmblemPosition
    {
        [JsonProperty("horizontal")]
        public string Horizontal { get; set; }
        [JsonProperty("vertical")]
        public string Vertical { get; set; }
    }
}

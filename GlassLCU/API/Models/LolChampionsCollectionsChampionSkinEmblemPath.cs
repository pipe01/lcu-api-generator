using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsCollectionsChampionSkinEmblemPath
    {
        [JsonProperty("large")]
        public string Large { get; set; }
        [JsonProperty("small")]
        public string Small { get; set; }
    }
}

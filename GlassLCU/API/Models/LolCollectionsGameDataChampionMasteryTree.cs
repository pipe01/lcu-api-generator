using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsGameDataChampionMasteryTree
    {
        [JsonProperty("groups")]
        public LolCollectionsGameDataChampionMasteryGroup[] Groups { get; set; }
    }
}

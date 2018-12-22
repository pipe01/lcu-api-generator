using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsGameDataChampionMasteries
    {
        [JsonProperty("tree")]
        public LolCollectionsGameDataChampionMasteryTree Tree { get; set; }
    }
}

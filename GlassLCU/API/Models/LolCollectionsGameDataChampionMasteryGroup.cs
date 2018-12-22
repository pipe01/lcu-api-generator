using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsGameDataChampionMasteryGroup
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("rows")]
        public LolCollectionsGameDataChampionMasteryRow[] Rows { get; set; }
    }
}

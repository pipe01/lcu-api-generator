using Newtonsoft.Json;

namespace LCU_API_Generator
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

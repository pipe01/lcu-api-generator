using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsGameDataChampionSummary
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampionsGameDataChampionSummary
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}

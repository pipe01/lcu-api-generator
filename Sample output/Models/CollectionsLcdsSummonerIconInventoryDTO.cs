using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class CollectionsLcdsSummonerIconInventoryDTO
    {
        [JsonProperty("dateString")]
        public string DateString { get; set; }
        [JsonProperty("summonerIcons")]
        public CollectionsLcdsSummonerIcon[] SummonerIcons { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

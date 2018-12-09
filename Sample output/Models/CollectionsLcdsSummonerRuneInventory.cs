using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class CollectionsLcdsSummonerRuneInventory
    {
        [JsonProperty("dateString")]
        public string DateString { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerRunes")]
        public CollectionsLcdsSummonerRune[] SummonerRunes { get; set; }
    }
}

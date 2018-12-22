using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

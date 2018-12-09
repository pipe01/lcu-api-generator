using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class CollectionsLcdsSummonerIcon
    {
        [JsonProperty("iconId")]
        public int IconId { get; set; }
        [JsonProperty("purchaseDate")]
        public long PurchaseDate { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class CollectionsLcdsSummonerRune
    {
        [JsonProperty("purchaseDate")]
        public long PurchaseDate { get; set; }
        [JsonProperty("purchased")]
        public long Purchased { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("runeId")]
        public int RuneId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

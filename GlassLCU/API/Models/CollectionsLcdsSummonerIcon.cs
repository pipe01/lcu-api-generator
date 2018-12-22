using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

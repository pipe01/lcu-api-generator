using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsCollectionsRental
    {
        [JsonProperty("endDate")]
        public long EndDate { get; set; }
        [JsonProperty("purchaseDate")]
        public long PurchaseDate { get; set; }
        [JsonProperty("rented")]
        public bool Rented { get; set; }
        [JsonProperty("winCountRemaining")]
        public int WinCountRemaining { get; set; }
    }
}

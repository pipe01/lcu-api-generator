using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsRental
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

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersUIOffer
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("discountPrice")]
        public long DiscountPrice { get; set; }
        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("originalPrice")]
        public long OriginalPrice { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
        [JsonProperty("revealed")]
        public bool Revealed { get; set; }
        [JsonProperty("skinId")]
        public int SkinId { get; set; }
        [JsonProperty("skinName")]
        public string SkinName { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

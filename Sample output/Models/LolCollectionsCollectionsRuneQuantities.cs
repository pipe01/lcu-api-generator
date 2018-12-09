using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsRuneQuantities
    {
        [JsonProperty("runeQuantities")]
        public LolCollectionsCollectionsRuneQuantity[] RuneQuantities { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

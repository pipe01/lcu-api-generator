using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsRuneQuantity
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("runeId")]
        public int RuneId { get; set; }
    }
}

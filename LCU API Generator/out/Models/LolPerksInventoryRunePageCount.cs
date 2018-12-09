using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksInventoryRunePageCount
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}

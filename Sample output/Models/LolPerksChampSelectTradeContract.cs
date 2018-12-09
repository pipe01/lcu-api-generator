using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksChampSelectTradeContract
    {
        [JsonProperty("cellId")]
        public long CellId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("state")]
        public LolPerksChampSelectTradeState State { get; set; }
    }
}

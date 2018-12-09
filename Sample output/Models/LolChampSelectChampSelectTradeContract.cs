using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectChampSelectTradeContract
    {
        [JsonProperty("cellId")]
        public long CellId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("state")]
        public LolChampSelectChampSelectTradeState State { get; set; }
    }
}

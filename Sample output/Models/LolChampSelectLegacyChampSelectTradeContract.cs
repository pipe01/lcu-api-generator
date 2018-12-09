using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyChampSelectTradeContract
    {
        [JsonProperty("cellId")]
        public long CellId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("state")]
        public LolChampSelectLegacyChampSelectTradeState State { get; set; }
    }
}

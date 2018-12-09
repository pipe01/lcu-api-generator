using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPurchaseWidgetWallet
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("balances")]
        public LolPurchaseWidgetBalance[] Balances { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}

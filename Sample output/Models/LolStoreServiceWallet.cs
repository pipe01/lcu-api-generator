using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreServiceWallet
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("balances")]
        public LolStoreServiceBalance[] Balances { get; set; }
    }
}

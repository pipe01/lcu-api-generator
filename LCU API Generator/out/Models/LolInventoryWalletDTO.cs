using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryWalletDTO
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("balances")]
        public object Balances { get; set; }
        [JsonProperty("balancesJwt")]
        public string BalancesJwt { get; set; }
        [JsonProperty("expires")]
        public string Expires { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
    }
}

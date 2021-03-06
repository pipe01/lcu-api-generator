//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

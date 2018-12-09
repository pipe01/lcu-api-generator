using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryWalletCacheEntry
    {
        [JsonProperty("expirationMS")]
        public long ExpirationMS { get; set; }
        [JsonProperty("issuedAtMS")]
        public long IssuedAtMS { get; set; }
        [JsonProperty("receivedAtMS")]
        public long ReceivedAtMS { get; set; }
        [JsonProperty("signedBalancesJwt")]
        public string SignedBalancesJwt { get; set; }
        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}

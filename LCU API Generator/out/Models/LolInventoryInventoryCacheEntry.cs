using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryInventoryCacheEntry
    {
        [JsonProperty("expirationMS")]
        public long ExpirationMS { get; set; }
        [JsonProperty("issuedAtMS")]
        public long IssuedAtMS { get; set; }
        [JsonProperty("receivedAtMS")]
        public long ReceivedAtMS { get; set; }
        [JsonProperty("signedInventoryJwt")]
        public string SignedInventoryJwt { get; set; }
        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}

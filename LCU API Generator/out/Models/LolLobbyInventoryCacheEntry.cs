using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyInventoryCacheEntry
    {
        [JsonProperty("expirationMS")]
        public long ExpirationMS { get; set; }
        [JsonProperty("signedInventoryJwt")]
        public string SignedInventoryJwt { get; set; }
        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}

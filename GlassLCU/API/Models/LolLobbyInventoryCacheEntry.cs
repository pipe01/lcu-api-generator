using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

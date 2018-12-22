using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyCollectionsOwnership
    {
        [JsonProperty("freeToPlayReward")]
        public bool FreeToPlayReward { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
        [JsonProperty("rental")]
        public LolLobbyCollectionsRental Rental { get; set; }
    }
}

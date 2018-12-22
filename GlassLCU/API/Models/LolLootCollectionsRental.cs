using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootCollectionsRental
    {
        [JsonProperty("rented")]
        public bool Rented { get; set; }
    }
}

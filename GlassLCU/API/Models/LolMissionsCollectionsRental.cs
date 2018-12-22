using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMissionsCollectionsRental
    {
        [JsonProperty("rented")]
        public bool Rented { get; set; }
    }
}

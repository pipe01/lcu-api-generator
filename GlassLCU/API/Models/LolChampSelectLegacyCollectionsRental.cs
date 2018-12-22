using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectLegacyCollectionsRental
    {
        [JsonProperty("rented")]
        public bool Rented { get; set; }
    }
}

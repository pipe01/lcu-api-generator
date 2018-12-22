using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolFeaturedModesGameflowAvailability
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }
        [JsonProperty("state")]
        public LolFeaturedModesGameflowAvailabilityState State { get; set; }
    }
}

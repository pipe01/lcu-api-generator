using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class SpectatorLcdsSpectateAvailabilityResponseDto
    {
        [JsonProperty("availableForWatching")]
        public string[] AvailableForWatching { get; set; }
    }
}

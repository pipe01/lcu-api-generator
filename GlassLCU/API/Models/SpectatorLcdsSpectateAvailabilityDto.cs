using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class SpectatorLcdsSpectateAvailabilityDto
    {
        [JsonProperty("teamOrSummonerIds")]
        public string[] TeamOrSummonerIds { get; set; }
    }
}

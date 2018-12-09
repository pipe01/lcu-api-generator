using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class SpectatorLcdsSpectateAvailabilityDto
    {
        [JsonProperty("teamOrSummonerIds")]
        public string[] TeamOrSummonerIds { get; set; }
    }
}

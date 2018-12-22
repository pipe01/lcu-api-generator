using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyCustomEligibilityDto
    {
        [JsonProperty("eligible")]
        public bool Eligible { get; set; }
        [JsonProperty("restrictions")]
        public LolLobbyGatekeeperRestrictionDto[] Restrictions { get; set; }
    }
}

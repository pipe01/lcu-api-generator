using Newtonsoft.Json;

namespace LCU_API_Generator
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

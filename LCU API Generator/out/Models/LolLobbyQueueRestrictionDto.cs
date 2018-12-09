using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyQueueRestrictionDto
    {
        [JsonProperty("gatekeeperRestrictions")]
        public LolLobbyGatekeeperRestrictionDto[] GatekeeperRestrictions { get; set; }
    }
}

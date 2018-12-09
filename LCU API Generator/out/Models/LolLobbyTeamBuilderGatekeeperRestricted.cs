using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderGatekeeperRestricted
    {
        [JsonProperty("gatekeeperRestrictions")]
        public LolLobbyTeamBuilderGatekeeperRestriction[] GatekeeperRestrictions { get; set; }
    }
}

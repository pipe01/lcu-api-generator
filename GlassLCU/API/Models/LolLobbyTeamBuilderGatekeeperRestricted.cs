using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderGatekeeperRestricted
    {
        [JsonProperty("gatekeeperRestrictions")]
        public LolLobbyTeamBuilderGatekeeperRestriction[] GatekeeperRestrictions { get; set; }
    }
}

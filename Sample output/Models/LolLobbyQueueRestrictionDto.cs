//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyQueueRestrictionDto
    {
        [JsonProperty("gatekeeperRestrictions")]
        public LolLobbyGatekeeperRestrictionDto[] GatekeeperRestrictions { get; set; }
    }
}

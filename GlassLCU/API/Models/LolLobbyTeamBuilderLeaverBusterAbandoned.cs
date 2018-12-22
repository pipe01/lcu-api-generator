using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderLeaverBusterAbandoned
    {
        [JsonProperty("abandonerName")]
        public string AbandonerName { get; set; }
    }
}

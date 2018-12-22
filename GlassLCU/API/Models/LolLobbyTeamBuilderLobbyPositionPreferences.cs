using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderLobbyPositionPreferences
    {
        [JsonProperty("firstPreference")]
        public string FirstPreference { get; set; }
        [JsonProperty("secondPreference")]
        public string SecondPreference { get; set; }
    }
}

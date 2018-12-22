using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderChampionSelectPreferences
    {
        [JsonProperty("skins")]
        public object Skins { get; set; }
        [JsonProperty("spells")]
        public object Spells { get; set; }
    }
}

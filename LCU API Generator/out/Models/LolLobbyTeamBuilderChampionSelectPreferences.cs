using Newtonsoft.Json;

namespace LCU_API_Generator
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

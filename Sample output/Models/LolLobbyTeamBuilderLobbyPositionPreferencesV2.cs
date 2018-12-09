using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderLobbyPositionPreferencesV2
    {
        [JsonProperty("excludedPreference")]
        public string ExcludedPreference { get; set; }
        [JsonProperty("firstPreference")]
        public string FirstPreference { get; set; }
        [JsonProperty("secondPreference")]
        public string SecondPreference { get; set; }
    }
}

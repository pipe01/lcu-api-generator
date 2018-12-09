using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderSpecifyPositionPreferencesV2
    {
        [JsonProperty("excludedPreference")]
        public string ExcludedPreference { get; set; }
        [JsonProperty("firstPreference")]
        public string FirstPreference { get; set; }
        [JsonProperty("secondPreference")]
        public string SecondPreference { get; set; }
    }
}

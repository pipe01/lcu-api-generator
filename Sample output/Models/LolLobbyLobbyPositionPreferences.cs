using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyPositionPreferences
    {
        [JsonProperty("firstPreference")]
        public string FirstPreference { get; set; }
        [JsonProperty("secondPreference")]
        public string SecondPreference { get; set; }
    }
}

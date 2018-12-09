using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderTbLobbyEnabledFeaturesResource
    {
        [JsonProperty("enabledFeatures")]
        public string[] EnabledFeatures { get; set; }
    }
}

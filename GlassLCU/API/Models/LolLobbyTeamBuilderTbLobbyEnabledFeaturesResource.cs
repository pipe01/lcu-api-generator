using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderTbLobbyEnabledFeaturesResource
    {
        [JsonProperty("enabledFeatures")]
        public string[] EnabledFeatures { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderSettingCategoryResource
    {
        [JsonProperty("data")]
        public LolLobbyTeamBuilderChampionSelectPreferences Data { get; set; }
        [JsonProperty("schemaVersion")]
        public int SchemaVersion { get; set; }
    }
}

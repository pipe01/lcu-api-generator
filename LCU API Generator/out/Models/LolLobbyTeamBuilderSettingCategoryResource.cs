using Newtonsoft.Json;

namespace LCU_API_Generator
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

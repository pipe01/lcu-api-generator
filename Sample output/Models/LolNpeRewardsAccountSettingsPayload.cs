using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsAccountSettingsPayload
    {
        [JsonProperty("data")]
        public LolNpeRewardsAccountSettingsData Data { get; set; }
        [JsonProperty("schemaVersion")]
        public long SchemaVersion { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

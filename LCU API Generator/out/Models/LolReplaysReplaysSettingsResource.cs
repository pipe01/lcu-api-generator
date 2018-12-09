using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolReplaysReplaysSettingsResource
    {
        [JsonProperty("data")]
        public LolReplaysReplaysSettingsData Data { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameflowReplaysSettingsResource
    {
        [JsonProperty("data")]
        public LolGameflowReplaysSettingsData Data { get; set; }
    }
}

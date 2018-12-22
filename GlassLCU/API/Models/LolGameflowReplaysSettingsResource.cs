using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowReplaysSettingsResource
    {
        [JsonProperty("data")]
        public LolGameflowReplaysSettingsData Data { get; set; }
    }
}

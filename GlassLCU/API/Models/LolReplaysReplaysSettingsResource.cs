using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolReplaysReplaysSettingsResource
    {
        [JsonProperty("data")]
        public LolReplaysReplaysSettingsData Data { get; set; }
    }
}

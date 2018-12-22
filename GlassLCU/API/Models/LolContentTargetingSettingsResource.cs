using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolContentTargetingSettingsResource
    {
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}

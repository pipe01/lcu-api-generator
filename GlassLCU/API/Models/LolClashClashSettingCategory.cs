using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashClashSettingCategory
    {
        [JsonProperty("simpleStateFlagIds")]
        public string[] SimpleStateFlagIds { get; set; }
    }
}

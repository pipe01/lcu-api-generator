using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashClashSettingCategory
    {
        [JsonProperty("simpleStateFlagIds")]
        public string[] SimpleStateFlagIds { get; set; }
    }
}

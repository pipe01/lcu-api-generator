using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolContentTargetingContentTargetingFilterResponse
    {
        [JsonProperty("filters")]
        public string[] Filters { get; set; }
    }
}

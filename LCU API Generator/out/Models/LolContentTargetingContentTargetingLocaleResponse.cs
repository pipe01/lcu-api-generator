using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolContentTargetingContentTargetingLocaleResponse
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}

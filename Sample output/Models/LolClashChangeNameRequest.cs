using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashChangeNameRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

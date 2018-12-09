using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderLinkResource
    {
        [JsonProperty("linked")]
        public bool Linked { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}

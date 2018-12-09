using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderUrlResource
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

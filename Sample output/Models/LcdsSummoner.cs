using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsSummoner
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("sumId")]
        public long SumId { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderContactCountResource
    {
        [JsonProperty("count")]
        public long Count { get; set; }
    }
}

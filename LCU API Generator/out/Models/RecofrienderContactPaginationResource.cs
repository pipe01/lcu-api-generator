using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderContactPaginationResource
    {
        [JsonProperty("cached")]
        public long Cached { get; set; }
        [JsonProperty("count")]
        public long Count { get; set; }
        [JsonProperty("limit")]
        public long Limit { get; set; }
        [JsonProperty("more")]
        public bool More { get; set; }
        [JsonProperty("start")]
        public long Start { get; set; }
        [JsonProperty("total")]
        public long Total { get; set; }
    }
}

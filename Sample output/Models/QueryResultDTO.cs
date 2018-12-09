using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class QueryResultDTO
    {
        [JsonProperty("lastUpdate")]
        public long LastUpdate { get; set; }
        [JsonProperty("queryToLootNames")]
        public object QueryToLootNames { get; set; }
    }
}

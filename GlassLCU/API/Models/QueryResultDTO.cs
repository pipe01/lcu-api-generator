using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

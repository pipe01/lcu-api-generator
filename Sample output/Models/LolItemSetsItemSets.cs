using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolItemSetsItemSets
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("itemSets")]
        public LolItemSetsItemSet[] ItemSets { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}

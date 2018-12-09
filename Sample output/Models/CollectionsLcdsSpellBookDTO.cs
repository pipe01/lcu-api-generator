using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class CollectionsLcdsSpellBookDTO
    {
        [JsonProperty("bookPages")]
        public CollectionsLcdsSpellBookPageDTO[] BookPages { get; set; }
        [JsonProperty("dateString")]
        public string DateString { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

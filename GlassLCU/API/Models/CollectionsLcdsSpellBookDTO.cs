using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

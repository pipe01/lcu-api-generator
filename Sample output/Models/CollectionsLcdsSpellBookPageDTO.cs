using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class CollectionsLcdsSpellBookPageDTO
    {
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }
        [JsonProperty("current")]
        public bool Current { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("pageId")]
        public int PageId { get; set; }
        [JsonProperty("slotEntries")]
        public CollectionsLcdsSlotEntry[] SlotEntries { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

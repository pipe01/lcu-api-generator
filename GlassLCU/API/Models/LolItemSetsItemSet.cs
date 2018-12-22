using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolItemSetsItemSet
    {
        [JsonProperty("associatedChampions")]
        public int[] AssociatedChampions { get; set; }
        [JsonProperty("associatedMaps")]
        public int[] AssociatedMaps { get; set; }
        [JsonProperty("blocks")]
        public LolItemSetsItemSetBlock[] Blocks { get; set; }
        [JsonProperty("map")]
        public string Map { get; set; }
        [JsonProperty("mode")]
        public string Mode { get; set; }
        [JsonProperty("preferredItemSlots")]
        public LolItemSetsPreferredItemSlot[] PreferredItemSlots { get; set; }
        [JsonProperty("sortrank")]
        public int Sortrank { get; set; }
        [JsonProperty("startedFrom")]
        public string StartedFrom { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}
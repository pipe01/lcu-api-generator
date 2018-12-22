using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLootDescription
    {
        [JsonProperty("childLootTableNames")]
        public string[] ChildLootTableNames { get; set; }
        [JsonProperty("childrenDescriptions")]
        public LolLootLootDescription[] ChildrenDescriptions { get; set; }
        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }
        [JsonProperty("localizedDescription")]
        public string LocalizedDescription { get; set; }
        [JsonProperty("localizedDescriptionLong")]
        public string LocalizedDescriptionLong { get; set; }
        [JsonProperty("lootName")]
        public string LootName { get; set; }
    }
}

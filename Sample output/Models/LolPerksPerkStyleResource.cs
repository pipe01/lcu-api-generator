using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksPerkStyleResource
    {
        [JsonProperty("allowedSubStyles")]
        public int[] AllowedSubStyles { get; set; }
        [JsonProperty("assetMap")]
        public object AssetMap { get; set; }
        [JsonProperty("defaultPageName")]
        public string DefaultPageName { get; set; }
        [JsonProperty("defaultPerks")]
        public int[] DefaultPerks { get; set; }
        [JsonProperty("defaultPerksWhenSplashed")]
        public int[] DefaultPerksWhenSplashed { get; set; }
        [JsonProperty("defaultStatModsPerSubStyle")]
        public LolPerksDefaultStatModsPerSubStyle[] DefaultStatModsPerSubStyle { get; set; }
        [JsonProperty("defaultSubStyle")]
        public int DefaultSubStyle { get; set; }
        [JsonProperty("iconPath")]
        public string IconPath { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isAdvanced")]
        public bool IsAdvanced { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slots")]
        public LolPerksPerkStyleSlotResource[] Slots { get; set; }
        [JsonProperty("subStyleBonus")]
        public LolPerksPerkSubStyleBonusResource[] SubStyleBonus { get; set; }
        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }
    }
}

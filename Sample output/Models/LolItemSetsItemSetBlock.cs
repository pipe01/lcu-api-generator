using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolItemSetsItemSetBlock
    {
        [JsonProperty("hideIfSummonerSpell")]
        public string HideIfSummonerSpell { get; set; }
        [JsonProperty("items")]
        public LolItemSetsItemSetItem[] Items { get; set; }
        [JsonProperty("showIfSummonerSpell")]
        public string ShowIfSummonerSpell { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

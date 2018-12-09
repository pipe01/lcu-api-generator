using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderTbdInventory
    {
        [JsonProperty("allChampionIds")]
        public int[] AllChampionIds { get; set; }
        [JsonProperty("disabledChampionIds")]
        public int[] DisabledChampionIds { get; set; }
        [JsonProperty("initialSpellIds")]
        public int[] InitialSpellIds { get; set; }
        [JsonProperty("lastSelectedSkinIdByChampionId")]
        public object LastSelectedSkinIdByChampionId { get; set; }
        [JsonProperty("skinIds")]
        public int[] SkinIds { get; set; }
        [JsonProperty("spellIds")]
        public int[] SpellIds { get; set; }
    }
}

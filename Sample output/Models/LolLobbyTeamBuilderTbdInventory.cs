//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

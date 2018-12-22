using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ChampSelectLcdsPlayerChampionSelectionDTO
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("selectedSkinIndex")]
        public int SelectedSkinIndex { get; set; }
        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }
        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }
        [JsonProperty("summonerInternalName")]
        public string SummonerInternalName { get; set; }
    }
}

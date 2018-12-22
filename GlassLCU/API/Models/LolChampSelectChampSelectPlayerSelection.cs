using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectChampSelectPlayerSelection
    {
        [JsonProperty("assignedPosition")]
        public string AssignedPosition { get; set; }
        [JsonProperty("cellId")]
        public long CellId { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("championPickIntent")]
        public int ChampionPickIntent { get; set; }
        [JsonProperty("playerType")]
        public string PlayerType { get; set; }
        [JsonProperty("selectedSkinId")]
        public int SelectedSkinId { get; set; }
        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }
        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("team")]
        public int Team { get; set; }
        [JsonProperty("wardSkinId")]
        public long WardSkinId { get; set; }
    }
}

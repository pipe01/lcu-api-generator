using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderCellV1
    {
        [JsonProperty("assignedPosition")]
        public string AssignedPosition { get; set; }
        [JsonProperty("cellId")]
        public int CellId { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("championPickIntent")]
        public int ChampionPickIntent { get; set; }
        [JsonProperty("skinId")]
        public int SkinId { get; set; }
        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }
        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
    }
}

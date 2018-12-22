using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderChampSelectMySelection
    {
        [JsonProperty("selectedSkinId")]
        public int SelectedSkinId { get; set; }
        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }
        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }
        [JsonProperty("wardSkinId")]
        public long WardSkinId { get; set; }
    }
}
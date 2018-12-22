using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPremadeMemberDto
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("role")]
        public LolLobbyPartyMemberRoleEnum Role { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoicePlayerDto
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("role")]
        public LolPremadeVoicePartyMemberRoleEnum Role { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

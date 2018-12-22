using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPlayerDto
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("createdAt")]
        public long CreatedAt { get; set; }
        [JsonProperty("currentParty")]
        public LolLobbyPartyDto CurrentParty { get; set; }
        [JsonProperty("eligibilityHash")]
        public long EligibilityHash { get; set; }
        [JsonProperty("parties")]
        public LolLobbyPartyMemberDto[] Parties { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("registration")]
        public LolLobbyRegistrationCredentials Registration { get; set; }
        [JsonProperty("serverUtcMillis")]
        public long ServerUtcMillis { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("version")]
        public long Version { get; set; }
    }
}

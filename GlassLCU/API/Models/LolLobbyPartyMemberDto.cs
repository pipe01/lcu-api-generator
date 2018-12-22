using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPartyMemberDto
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("canInvite")]
        public bool CanInvite { get; set; }
        [JsonProperty("gameMode")]
        public LolLobbyGameModeDto GameMode { get; set; }
        [JsonProperty("inviteTimestamp")]
        public long InviteTimestamp { get; set; }
        [JsonProperty("invitedBySummonerId")]
        public long InvitedBySummonerId { get; set; }
        [JsonProperty("metadata")]
        public LolLobbyPartyMemberMetadataDto Metadata { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("ready")]
        public bool Ready { get; set; }
        [JsonProperty("role")]
        public LolLobbyPartyMemberRoleEnum Role { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

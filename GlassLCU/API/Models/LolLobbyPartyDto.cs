using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPartyDto
    {
        [JsonProperty("activeRestrictions")]
        public LolLobbyQueueRestrictionDto ActiveRestrictions { get; set; }
        [JsonProperty("activityLocked")]
        public bool ActivityLocked { get; set; }
        [JsonProperty("activityResumeUtcMillis")]
        public long ActivityResumeUtcMillis { get; set; }
        [JsonProperty("activityStartedUtcMillis")]
        public long ActivityStartedUtcMillis { get; set; }
        [JsonProperty("chat")]
        public LolLobbyPartyChatDto Chat { get; set; }
        [JsonProperty("eligibilityHash")]
        public long EligibilityHash { get; set; }
        [JsonProperty("eligibilityRestrictions")]
        public LolLobbyGatekeeperRestrictionDto[] EligibilityRestrictions { get; set; }
        [JsonProperty("gameMode")]
        public LolLobbyGameModeDto GameMode { get; set; }
        [JsonProperty("maxPartySize")]
        public int MaxPartySize { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("partyType")]
        public string PartyType { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("players")]
        public LolLobbyPartyMemberDto[] Players { get; set; }
        [JsonProperty("version")]
        public long Version { get; set; }
    }
}

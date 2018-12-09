using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyPartyInviteDto
    {
        [JsonProperty("gameMode")]
        public LolLobbyGameModeDto GameMode { get; set; }
        [JsonProperty("invitedByPuuid")]
        public string InvitedByPuuid { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("partyVersion")]
        public int PartyVersion { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
    }
}

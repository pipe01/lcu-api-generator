using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPartyQueueEligibilityDto
    {
        [JsonProperty("availableQueueIds")]
        public int[] AvailableQueueIds { get; set; }
        [JsonProperty("partyRestrictions")]
        public LolLobbyGatekeeperRestrictionDto[] PartyRestrictions { get; set; }
    }
}

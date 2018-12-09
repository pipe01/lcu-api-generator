using Newtonsoft.Json;

namespace LCU_API_Generator
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

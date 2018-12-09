using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderLobbyMember
    {
        [JsonProperty("autoFillEligible")]
        public bool AutoFillEligible { get; set; }
        [JsonProperty("autoFillProtectedForPromos")]
        public bool AutoFillProtectedForPromos { get; set; }
        [JsonProperty("autoFillProtectedForSoloing")]
        public bool AutoFillProtectedForSoloing { get; set; }
        [JsonProperty("autoFillProtectedForStreaking")]
        public bool AutoFillProtectedForStreaking { get; set; }
        [JsonProperty("canInviteOthers")]
        public bool CanInviteOthers { get; set; }
        [JsonProperty("excludedPositionPreference")]
        public string ExcludedPositionPreference { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("isOwner")]
        public bool IsOwner { get; set; }
        [JsonProperty("positionPreferences")]
        public LolLobbyTeamBuilderLobbyPositionPreferences PositionPreferences { get; set; }
        [JsonProperty("showPositionExcluder")]
        public bool ShowPositionExcluder { get; set; }
    }
}

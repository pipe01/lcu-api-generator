using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderTbLobbySlotResource
    {
        [JsonProperty("autoFillEligible")]
        public bool AutoFillEligible { get; set; }
        [JsonProperty("autoFillProtectedForPromos")]
        public bool AutoFillProtectedForPromos { get; set; }
        [JsonProperty("autoFillProtectedForSoloing")]
        public bool AutoFillProtectedForSoloing { get; set; }
        [JsonProperty("autoFillProtectedForStreaking")]
        public bool AutoFillProtectedForStreaking { get; set; }
        [JsonProperty("draftPositionPreferences")]
        public string[] DraftPositionPreferences { get; set; }
        [JsonProperty("excludedPositionPreference")]
        public string ExcludedPositionPreference { get; set; }
        [JsonProperty("showPositionExcluder")]
        public bool ShowPositionExcluder { get; set; }
        [JsonProperty("slotId")]
        public int SlotId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

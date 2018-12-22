using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyMember
    {
        [JsonProperty("autoFillEligible")]
        public bool AutoFillEligible { get; set; }
        [JsonProperty("autoFillProtectedForPromos")]
        public bool AutoFillProtectedForPromos { get; set; }
        [JsonProperty("autoFillProtectedForSoloing")]
        public bool AutoFillProtectedForSoloing { get; set; }
        [JsonProperty("autoFillProtectedForStreaking")]
        public bool AutoFillProtectedForStreaking { get; set; }
        [JsonProperty("botChampionId")]
        public int BotChampionId { get; set; }
        [JsonProperty("botDifficulty")]
        public LolLobbyLobbyBotDifficulty BotDifficulty { get; set; }
        [JsonProperty("canInviteOthers")]
        public bool CanInviteOthers { get; set; }
        [JsonProperty("excludedPositionPreference")]
        public string ExcludedPositionPreference { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("isBot")]
        public bool IsBot { get; set; }
        [JsonProperty("isOwner")]
        public bool IsOwner { get; set; }
        [JsonProperty("isSpectator")]
        public bool IsSpectator { get; set; }
        [JsonProperty("positionPreferences")]
        public LolLobbyLobbyPositionPreferences PositionPreferences { get; set; }
        [JsonProperty("showPositionExcluder")]
        public bool ShowPositionExcluder { get; set; }
        [JsonProperty("summonerInternalName")]
        public string SummonerInternalName { get; set; }
    }
}

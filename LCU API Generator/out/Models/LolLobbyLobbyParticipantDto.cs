using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyParticipantDto
    {
        [JsonProperty("allowedChangeActivity")]
        public bool AllowedChangeActivity { get; set; }
        [JsonProperty("allowedInviteOthers")]
        public bool AllowedInviteOthers { get; set; }
        [JsonProperty("allowedKickOthers")]
        public bool AllowedKickOthers { get; set; }
        [JsonProperty("allowedStartActivity")]
        public bool AllowedStartActivity { get; set; }
        [JsonProperty("allowedToggleInvite")]
        public bool AllowedToggleInvite { get; set; }
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
        [JsonProperty("botId")]
        public string BotId { get; set; }
        [JsonProperty("firstPositionPreference")]
        public string FirstPositionPreference { get; set; }
        [JsonProperty("isBot")]
        public bool IsBot { get; set; }
        [JsonProperty("isLeader")]
        public bool IsLeader { get; set; }
        [JsonProperty("isSpectator")]
        public bool IsSpectator { get; set; }
        [JsonProperty("lastSeasonHighestRank")]
        public string LastSeasonHighestRank { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("ready")]
        public bool Ready { get; set; }
        [JsonProperty("secondPositionPreference")]
        public string SecondPositionPreference { get; set; }
        [JsonProperty("showGhostedBanner")]
        public bool ShowGhostedBanner { get; set; }
        [JsonProperty("summonerIconId")]
        public int SummonerIconId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerInternalName")]
        public string SummonerInternalName { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
    }
}

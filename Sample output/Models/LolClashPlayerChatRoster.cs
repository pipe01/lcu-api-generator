using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashPlayerChatRoster
    {
        [JsonProperty("endTimeMs")]
        public long EndTimeMs { get; set; }
        [JsonProperty("iconColorId")]
        public int IconColorId { get; set; }
        [JsonProperty("iconId")]
        public int IconId { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("isRegistered")]
        public bool IsRegistered { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("playerState")]
        public LolClashPlayerState PlayerState { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("startTimeMs")]
        public long StartTimeMs { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("tournamentState")]
        public LolClashTournamentState TournamentState { get; set; }
    }
}
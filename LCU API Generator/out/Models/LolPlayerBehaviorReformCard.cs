using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerBehaviorReformCard
    {
        [JsonProperty("chatLogs")]
        public string[] ChatLogs { get; set; }
        [JsonProperty("gameIds")]
        public long[] GameIds { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("playerFacingMessage")]
        public string PlayerFacingMessage { get; set; }
        [JsonProperty("punishmentLengthGames")]
        public long PunishmentLengthGames { get; set; }
        [JsonProperty("punishmentLengthTime")]
        public long PunishmentLengthTime { get; set; }
        [JsonProperty("punishmentType")]
        public string PunishmentType { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("restrictedChatGamesRemaining")]
        public long RestrictedChatGamesRemaining { get; set; }
        [JsonProperty("timeWhenPunishmentExpires")]
        public long TimeWhenPunishmentExpires { get; set; }
    }
}

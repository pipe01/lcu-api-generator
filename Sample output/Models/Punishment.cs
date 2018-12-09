using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class Punishment
    {
        [JsonProperty("permaBan")]
        public bool PermaBan { get; set; }
        [JsonProperty("playerFacingMessage")]
        public string PlayerFacingMessage { get; set; }
        [JsonProperty("punishedForChatLogs")]
        public string[] PunishedForChatLogs { get; set; }
        [JsonProperty("punishedForGameIds")]
        public long[] PunishedForGameIds { get; set; }
        [JsonProperty("punishedUntilDateMillis")]
        public long PunishedUntilDateMillis { get; set; }
        [JsonProperty("punishmentLengthGames")]
        public long PunishmentLengthGames { get; set; }
        [JsonProperty("punishmentLengthMillis")]
        public long PunishmentLengthMillis { get; set; }
        [JsonProperty("punishmentReason")]
        public string PunishmentReason { get; set; }
        [JsonProperty("punishmentType")]
        public string PunishmentType { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MatchmakingLcdsMatchMakerParams
    {
        [JsonProperty("botDifficulty")]
        public string BotDifficulty { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("languages")]
        public string Languages { get; set; }
        [JsonProperty("lastMaestroMessage")]
        public string LastMaestroMessage { get; set; }
        [JsonProperty("queueIds")]
        public int[] QueueIds { get; set; }
        [JsonProperty("team")]
        public long[] Team { get; set; }
        [JsonProperty("teamId")]
        public long TeamId { get; set; }
    }
}

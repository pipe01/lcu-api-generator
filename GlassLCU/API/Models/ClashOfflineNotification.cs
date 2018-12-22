using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ClashOfflineNotification
    {
        [JsonProperty("metaData")]
        public object MetaData { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}

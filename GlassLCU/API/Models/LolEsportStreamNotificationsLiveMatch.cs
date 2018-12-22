using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsLiveMatch
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("streamGroup")]
        public string StreamGroup { get; set; }
        [JsonProperty("teams")]
        public LolEsportStreamNotificationsLiveMatchTeam[] Teams { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("tournamentDescription")]
        public string TournamentDescription { get; set; }
    }
}

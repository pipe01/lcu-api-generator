using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsESportsStreams
    {
        [JsonProperty("teamAAcronym")]
        public string TeamAAcronym { get; set; }
        [JsonProperty("teamAGuid")]
        public string TeamAGuid { get; set; }
        [JsonProperty("teamAId")]
        public long TeamAId { get; set; }
        [JsonProperty("teamALogoUrl")]
        public string TeamALogoUrl { get; set; }
        [JsonProperty("teamAName")]
        public string TeamAName { get; set; }
        [JsonProperty("teamBAcronym")]
        public string TeamBAcronym { get; set; }
        [JsonProperty("teamBGuid")]
        public string TeamBGuid { get; set; }
        [JsonProperty("teamBId")]
        public long TeamBId { get; set; }
        [JsonProperty("teamBLogoUrl")]
        public string TeamBLogoUrl { get; set; }
        [JsonProperty("teamBName")]
        public string TeamBName { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("tournamentDescription")]
        public string TournamentDescription { get; set; }
    }
}

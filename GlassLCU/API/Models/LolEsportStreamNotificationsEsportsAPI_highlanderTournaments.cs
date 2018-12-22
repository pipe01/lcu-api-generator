using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsEsportsAPI_highlanderTournaments
    {
        [JsonProperty("brackets")]
        public object Brackets { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("rosters")]
        public object Rosters { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
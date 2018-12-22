using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsEsportsAPI_highlanderTournaments_matches
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("input")]
        public LolEsportStreamNotificationsEsportsAPI_highlanderTournaments_roster[] Input { get; set; }
    }
}

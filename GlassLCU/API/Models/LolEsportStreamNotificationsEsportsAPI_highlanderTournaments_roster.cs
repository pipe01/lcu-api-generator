using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsEsportsAPI_highlanderTournaments_roster
    {
        [JsonProperty("roster")]
        public string Roster { get; set; }
    }
}

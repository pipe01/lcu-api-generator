using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsEsportsAPI_highlanderTournaments_brackets
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("matches")]
        public object Matches { get; set; }
    }
}
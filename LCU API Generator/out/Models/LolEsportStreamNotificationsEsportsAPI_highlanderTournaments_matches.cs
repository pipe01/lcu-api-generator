using Newtonsoft.Json;

namespace LCU_API_Generator
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

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEsportStreamNotificationsESportsAPI_streamgroups_root
    {
        [JsonProperty("highlanderTournaments")]
        public LolEsportStreamNotificationsEsportsAPI_highlanderTournaments[] HighlanderTournaments { get; set; }
        [JsonProperty("streamgroups")]
        public LolEsportStreamNotificationsESportsAPI_streamgroups[] Streamgroups { get; set; }
        [JsonProperty("teams")]
        public LolEsportStreamNotificationsEsportsAPI_teams[] Teams { get; set; }
    }
}

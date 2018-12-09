using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class TournamentPlayerInfoDTO
    {
        [JsonProperty("player")]
        public PlayerDTO Player { get; set; }
        [JsonProperty("rosterStats")]
        public RosterStatsDTO[] RosterStats { get; set; }
        [JsonProperty("seasonVp")]
        public int SeasonVp { get; set; }
        [JsonProperty("themeVps")]
        public ThemeVp[] ThemeVps { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
        [JsonProperty("time")]
        public long Time { get; set; }
        [JsonProperty("tournamentInfo")]
        public TournamentInfoDTO[] TournamentInfo { get; set; }
    }
}
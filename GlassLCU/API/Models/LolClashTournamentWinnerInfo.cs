using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashTournamentWinnerInfo
    {
        [JsonProperty("averageWinDuration")]
        public long AverageWinDuration { get; set; }
        [JsonProperty("createTime")]
        public long CreateTime { get; set; }
        [JsonProperty("logo")]
        public int Logo { get; set; }
        [JsonProperty("logoColor")]
        public int LogoColor { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("playerIds")]
        public long[] PlayerIds { get; set; }
        [JsonProperty("rosterId")]
        public long RosterId { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
    }
}
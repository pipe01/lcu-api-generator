using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaRegaliaWithPreferences
    {
        [JsonProperty("bannerType")]
        public string BannerType { get; set; }
        [JsonProperty("crestType")]
        public string CrestType { get; set; }
        [JsonProperty("highestRankedEntry")]
        public LolRegaliaRankedPositionInfo HighestRankedEntry { get; set; }
        [JsonProperty("lastSeasonHighestRank")]
        public string LastSeasonHighestRank { get; set; }
        [JsonProperty("preferredBannerType")]
        public string PreferredBannerType { get; set; }
        [JsonProperty("preferredCrestType")]
        public string PreferredCrestType { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2EndOfGamePlayer
    {
        [JsonProperty("botPlayer")]
        public bool BotPlayer { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("isReportingDisabled")]
        public bool IsReportingDisabled { get; set; }
        [JsonProperty("leaver")]
        public bool Leaver { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("skinIndex")]
        public int SkinIndex { get; set; }
        [JsonProperty("skinName")]
        public string SkinName { get; set; }
        [JsonProperty("stats")]
        public object Stats { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
        [JsonProperty("userId")]
        public long UserId { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}

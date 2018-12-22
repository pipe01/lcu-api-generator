using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPftPFTEndOfGamePlayer
    {
        [JsonProperty("botPlayer")]
        public bool BotPlayer { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("elo")]
        public int Elo { get; set; }
        [JsonProperty("eloChange")]
        public int EloChange { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("isReportingDisabled")]
        public bool IsReportingDisabled { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
        [JsonProperty("leaver")]
        public bool Leaver { get; set; }
        [JsonProperty("leaves")]
        public int Leaves { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("losses")]
        public int Losses { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("skinName")]
        public string SkinName { get; set; }
        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }
        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }
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

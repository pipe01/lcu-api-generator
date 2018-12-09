using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class EndOfGameLcdsPlayerParticipantStatsSummary
    {
        [JsonProperty("botPlayer")]
        public bool BotPlayer { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("detectedTeamPosition")]
        public string DetectedTeamPosition { get; set; }
        [JsonProperty("elo")]
        public int Elo { get; set; }
        [JsonProperty("eloChange")]
        public int EloChange { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
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
        [JsonProperty("selectedPosition")]
        public string SelectedPosition { get; set; }
        [JsonProperty("skinIndex")]
        public int SkinIndex { get; set; }
        [JsonProperty("skinName")]
        public string SkinName { get; set; }
        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }
        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }
        [JsonProperty("statistics")]
        public EndOfGameLcdsRawStatDTO[] Statistics { get; set; }
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

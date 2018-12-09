using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2EndOfGameStats
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }
        [JsonProperty("gameEndedInEarlySurrender")]
        public bool GameEndedInEarlySurrender { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("gameLength")]
        public int GameLength { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameMutators")]
        public string[] GameMutators { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("imbalancedTeamsNoPoints")]
        public bool ImbalancedTeamsNoPoints { get; set; }
        [JsonProperty("invalid")]
        public bool Invalid { get; set; }
        [JsonProperty("myTeamStatus")]
        public string MyTeamStatus { get; set; }
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
        [JsonProperty("ranked")]
        public bool Ranked { get; set; }
        [JsonProperty("reportGameId")]
        public long ReportGameId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("teams")]
        public LolHonorV2EndOfGameTeam[] Teams { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPftPFTEndOfGameStats
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("basePoints")]
        public int BasePoints { get; set; }
        [JsonProperty("battleBoostIpEarned")]
        public int BattleBoostIpEarned { get; set; }
        [JsonProperty("boostIpEarned")]
        public int BoostIpEarned { get; set; }
        [JsonProperty("boostXpEarned")]
        public int BoostXpEarned { get; set; }
        [JsonProperty("causedEarlySurrender")]
        public bool CausedEarlySurrender { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("coOpVsAiMinutesLeftToday")]
        public int CoOpVsAiMinutesLeftToday { get; set; }
        [JsonProperty("coOpVsAiMsecsUntilReset")]
        public int CoOpVsAiMsecsUntilReset { get; set; }
        [JsonProperty("completionBonusPoints")]
        public int CompletionBonusPoints { get; set; }
        [JsonProperty("customMinutesLeftToday")]
        public int CustomMinutesLeftToday { get; set; }
        [JsonProperty("customMsecsUntilReset")]
        public int CustomMsecsUntilReset { get; set; }
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }
        [JsonProperty("earlySurrenderAccomplice")]
        public bool EarlySurrenderAccomplice { get; set; }
        [JsonProperty("elo")]
        public int Elo { get; set; }
        [JsonProperty("eloChange")]
        public int EloChange { get; set; }
        [JsonProperty("experienceEarned")]
        public int ExperienceEarned { get; set; }
        [JsonProperty("experienceTotal")]
        public int ExperienceTotal { get; set; }
        [JsonProperty("firstWinBonus")]
        public int FirstWinBonus { get; set; }
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
        [JsonProperty("ipEarned")]
        public int IpEarned { get; set; }
        [JsonProperty("ipTotal")]
        public int IpTotal { get; set; }
        [JsonProperty("isAramGame")]
        public bool IsAramGame { get; set; }
        [JsonProperty("leveledUp")]
        public bool LeveledUp { get; set; }
        [JsonProperty("loyaltyBoostIpEarned")]
        public int LoyaltyBoostIpEarned { get; set; }
        [JsonProperty("loyaltyBoostXpEarned")]
        public int LoyaltyBoostXpEarned { get; set; }
        [JsonProperty("myTeamStatus")]
        public string MyTeamStatus { get; set; }
        [JsonProperty("newSpells")]
        public int[] NewSpells { get; set; }
        [JsonProperty("odinBonusIp")]
        public int OdinBonusIp { get; set; }
        [JsonProperty("partyRewardsBonusIpEarned")]
        public int PartyRewardsBonusIpEarned { get; set; }
        [JsonProperty("pointsPenalties")]
        public object PointsPenalties { get; set; }
        [JsonProperty("previousLevel")]
        public long PreviousLevel { get; set; }
        [JsonProperty("previousXpTotal")]
        public long PreviousXpTotal { get; set; }
        [JsonProperty("queueBonusEarned")]
        public int QueueBonusEarned { get; set; }
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
        [JsonProperty("ranked")]
        public bool Ranked { get; set; }
        [JsonProperty("reportGameId")]
        public long ReportGameId { get; set; }
        [JsonProperty("rerollData")]
        public LolPftPFTEndOfGamePoints RerollData { get; set; }
        [JsonProperty("roomName")]
        public string RoomName { get; set; }
        [JsonProperty("roomPassword")]
        public string RoomPassword { get; set; }
        [JsonProperty("rpEarned")]
        public int RpEarned { get; set; }
        [JsonProperty("sendStatsToTournamentProvider")]
        public bool SendStatsToTournamentProvider { get; set; }
        [JsonProperty("skinId")]
        public int SkinId { get; set; }
        [JsonProperty("skinIndex")]
        public int SkinIndex { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("talentPointsGained")]
        public int TalentPointsGained { get; set; }
        [JsonProperty("teamEarlySurrendered")]
        public bool TeamEarlySurrendered { get; set; }
        [JsonProperty("teams")]
        public LolPftPFTEndOfGameTeam[] Teams { get; set; }
        [JsonProperty("timeUntilNextFirstWinBonus")]
        public int TimeUntilNextFirstWinBonus { get; set; }
        [JsonProperty("userId")]
        public long UserId { get; set; }
    }
}

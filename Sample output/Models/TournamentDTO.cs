using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class TournamentDTO
    {
        [JsonProperty("bracketSize")]
        public string BracketSize { get; set; }
        [JsonProperty("buyInOptions")]
        public int[] BuyInOptions { get; set; }
        [JsonProperty("entryFee")]
        public int EntryFee { get; set; }
        [JsonProperty("honorRestriction")]
        public bool HonorRestriction { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("lastThemeOfSeason")]
        public bool LastThemeOfSeason { get; set; }
        [JsonProperty("maxSub")]
        public int MaxSub { get; set; }
        [JsonProperty("nameLocKey")]
        public string NameLocKey { get; set; }
        [JsonProperty("nameLocKeySecondary")]
        public string NameLocKeySecondary { get; set; }
        [JsonProperty("phases")]
        public TournamentPhaseDTO[] Phases { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("rankRestriction")]
        public bool RankRestriction { get; set; }
        [JsonProperty("rewardConfig")]
        public ClashRewardConfigClient[] RewardConfig { get; set; }
        [JsonProperty("rosterCreateDeadline")]
        public long RosterCreateDeadline { get; set; }
        [JsonProperty("rosterSize")]
        public int RosterSize { get; set; }
        [JsonProperty("scheduleEndTime")]
        public long ScheduleEndTime { get; set; }
        [JsonProperty("scheduleTime")]
        public long ScheduleTime { get; set; }
        [JsonProperty("scoutingTimeMs")]
        public long ScoutingTimeMs { get; set; }
        [JsonProperty("smsRestriction")]
        public bool SmsRestriction { get; set; }
        [JsonProperty("themeId")]
        public int ThemeId { get; set; }
        [JsonProperty("voiceEnabled")]
        public bool VoiceEnabled { get; set; }
    }
}
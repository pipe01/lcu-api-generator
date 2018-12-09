using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathParticipantStatistics
    {
        [JsonProperty("assists")]
        public long Assists { get; set; }
        [JsonProperty("goldEarned")]
        public long GoldEarned { get; set; }
        [JsonProperty("inhibitorKills")]
        public long InhibitorKills { get; set; }
        [JsonProperty("kills")]
        public long Kills { get; set; }
        [JsonProperty("largestKillingSpree")]
        public long LargestKillingSpree { get; set; }
        [JsonProperty("largestMultiKill")]
        public long LargestMultiKill { get; set; }
        [JsonProperty("neutralMinionsKilled")]
        public long NeutralMinionsKilled { get; set; }
        [JsonProperty("totalMinionsKilled")]
        public long TotalMinionsKilled { get; set; }
        [JsonProperty("turretKills")]
        public long TurretKills { get; set; }
    }
}

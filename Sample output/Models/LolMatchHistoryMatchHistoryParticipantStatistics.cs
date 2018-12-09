using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryParticipantStatistics
    {
        [JsonProperty("assists")]
        public long Assists { get; set; }
        [JsonProperty("causedEarlySurrender")]
        public bool CausedEarlySurrender { get; set; }
        [JsonProperty("champLevel")]
        public long ChampLevel { get; set; }
        [JsonProperty("combatPlayerScore")]
        public long CombatPlayerScore { get; set; }
        [JsonProperty("damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }
        [JsonProperty("damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }
        [JsonProperty("damageSelfMitigated")]
        public long DamageSelfMitigated { get; set; }
        [JsonProperty("deaths")]
        public long Deaths { get; set; }
        [JsonProperty("doubleKills")]
        public long DoubleKills { get; set; }
        [JsonProperty("earlySurrenderAccomplice")]
        public bool EarlySurrenderAccomplice { get; set; }
        [JsonProperty("firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }
        [JsonProperty("firstBloodKill")]
        public bool FirstBloodKill { get; set; }
        [JsonProperty("firstInhibitorAssist")]
        public bool FirstInhibitorAssist { get; set; }
        [JsonProperty("firstInhibitorKill")]
        public bool FirstInhibitorKill { get; set; }
        [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }
        [JsonProperty("firstTowerKill")]
        public bool FirstTowerKill { get; set; }
        [JsonProperty("gameEndedInEarlySurrender")]
        public bool GameEndedInEarlySurrender { get; set; }
        [JsonProperty("gameEndedInSurrender")]
        public bool GameEndedInSurrender { get; set; }
        [JsonProperty("goldEarned")]
        public long GoldEarned { get; set; }
        [JsonProperty("goldSpent")]
        public long GoldSpent { get; set; }
        [JsonProperty("inhibitorKills")]
        public long InhibitorKills { get; set; }
        [JsonProperty("item0")]
        public int Item0 { get; set; }
        [JsonProperty("item1")]
        public int Item1 { get; set; }
        [JsonProperty("item2")]
        public int Item2 { get; set; }
        [JsonProperty("item3")]
        public int Item3 { get; set; }
        [JsonProperty("item4")]
        public int Item4 { get; set; }
        [JsonProperty("item5")]
        public int Item5 { get; set; }
        [JsonProperty("item6")]
        public int Item6 { get; set; }
        [JsonProperty("killingSprees")]
        public long KillingSprees { get; set; }
        [JsonProperty("kills")]
        public long Kills { get; set; }
        [JsonProperty("largestCriticalStrike")]
        public long LargestCriticalStrike { get; set; }
        [JsonProperty("largestKillingSpree")]
        public long LargestKillingSpree { get; set; }
        [JsonProperty("largestMultiKill")]
        public long LargestMultiKill { get; set; }
        [JsonProperty("longestTimeSpentLiving")]
        public long LongestTimeSpentLiving { get; set; }
        [JsonProperty("magicDamageDealt")]
        public long MagicDamageDealt { get; set; }
        [JsonProperty("magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }
        [JsonProperty("magicalDamageTaken")]
        public long MagicalDamageTaken { get; set; }
        [JsonProperty("neutralMinionsKilled")]
        public long NeutralMinionsKilled { get; set; }
        [JsonProperty("neutralMinionsKilledEnemyJungle")]
        public long NeutralMinionsKilledEnemyJungle { get; set; }
        [JsonProperty("neutralMinionsKilledTeamJungle")]
        public long NeutralMinionsKilledTeamJungle { get; set; }
        [JsonProperty("objectivePlayerScore")]
        public long ObjectivePlayerScore { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("pentaKills")]
        public long PentaKills { get; set; }
        [JsonProperty("perk0")]
        public long Perk0 { get; set; }
        [JsonProperty("perk0Var1")]
        public long Perk0Var1 { get; set; }
        [JsonProperty("perk0Var2")]
        public long Perk0Var2 { get; set; }
        [JsonProperty("perk0Var3")]
        public long Perk0Var3 { get; set; }
        [JsonProperty("perk1")]
        public long Perk1 { get; set; }
        [JsonProperty("perk1Var1")]
        public long Perk1Var1 { get; set; }
        [JsonProperty("perk1Var2")]
        public long Perk1Var2 { get; set; }
        [JsonProperty("perk1Var3")]
        public long Perk1Var3 { get; set; }
        [JsonProperty("perk2")]
        public long Perk2 { get; set; }
        [JsonProperty("perk2Var1")]
        public long Perk2Var1 { get; set; }
        [JsonProperty("perk2Var2")]
        public long Perk2Var2 { get; set; }
        [JsonProperty("perk2Var3")]
        public long Perk2Var3 { get; set; }
        [JsonProperty("perk3")]
        public long Perk3 { get; set; }
        [JsonProperty("perk3Var1")]
        public long Perk3Var1 { get; set; }
        [JsonProperty("perk3Var2")]
        public long Perk3Var2 { get; set; }
        [JsonProperty("perk3Var3")]
        public long Perk3Var3 { get; set; }
        [JsonProperty("perk4")]
        public long Perk4 { get; set; }
        [JsonProperty("perk4Var1")]
        public long Perk4Var1 { get; set; }
        [JsonProperty("perk4Var2")]
        public long Perk4Var2 { get; set; }
        [JsonProperty("perk4Var3")]
        public long Perk4Var3 { get; set; }
        [JsonProperty("perk5")]
        public long Perk5 { get; set; }
        [JsonProperty("perk5Var1")]
        public long Perk5Var1 { get; set; }
        [JsonProperty("perk5Var2")]
        public long Perk5Var2 { get; set; }
        [JsonProperty("perk5Var3")]
        public long Perk5Var3 { get; set; }
        [JsonProperty("perkPrimaryStyle")]
        public long PerkPrimaryStyle { get; set; }
        [JsonProperty("perkSubStyle")]
        public long PerkSubStyle { get; set; }
        [JsonProperty("physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }
        [JsonProperty("physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }
        [JsonProperty("physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }
        [JsonProperty("playerScore0")]
        public long PlayerScore0 { get; set; }
        [JsonProperty("playerScore1")]
        public long PlayerScore1 { get; set; }
        [JsonProperty("playerScore2")]
        public long PlayerScore2 { get; set; }
        [JsonProperty("playerScore3")]
        public long PlayerScore3 { get; set; }
        [JsonProperty("playerScore4")]
        public long PlayerScore4 { get; set; }
        [JsonProperty("playerScore5")]
        public long PlayerScore5 { get; set; }
        [JsonProperty("playerScore6")]
        public long PlayerScore6 { get; set; }
        [JsonProperty("playerScore7")]
        public long PlayerScore7 { get; set; }
        [JsonProperty("playerScore8")]
        public long PlayerScore8 { get; set; }
        [JsonProperty("playerScore9")]
        public long PlayerScore9 { get; set; }
        [JsonProperty("quadraKills")]
        public long QuadraKills { get; set; }
        [JsonProperty("sightWardsBoughtInGame")]
        public long SightWardsBoughtInGame { get; set; }
        [JsonProperty("teamEarlySurrendered")]
        public bool TeamEarlySurrendered { get; set; }
        [JsonProperty("timeCCingOthers")]
        public long TimeCCingOthers { get; set; }
        [JsonProperty("totalDamageDealt")]
        public long TotalDamageDealt { get; set; }
        [JsonProperty("totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }
        [JsonProperty("totalDamageTaken")]
        public long TotalDamageTaken { get; set; }
        [JsonProperty("totalHeal")]
        public long TotalHeal { get; set; }
        [JsonProperty("totalMinionsKilled")]
        public long TotalMinionsKilled { get; set; }
        [JsonProperty("totalPlayerScore")]
        public long TotalPlayerScore { get; set; }
        [JsonProperty("totalScoreRank")]
        public long TotalScoreRank { get; set; }
        [JsonProperty("totalTimeCrowdControlDealt")]
        public long TotalTimeCrowdControlDealt { get; set; }
        [JsonProperty("totalUnitsHealed")]
        public long TotalUnitsHealed { get; set; }
        [JsonProperty("tripleKills")]
        public long TripleKills { get; set; }
        [JsonProperty("trueDamageDealt")]
        public long TrueDamageDealt { get; set; }
        [JsonProperty("trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }
        [JsonProperty("trueDamageTaken")]
        public long TrueDamageTaken { get; set; }
        [JsonProperty("turretKills")]
        public long TurretKills { get; set; }
        [JsonProperty("unrealKills")]
        public long UnrealKills { get; set; }
        [JsonProperty("visionScore")]
        public long VisionScore { get; set; }
        [JsonProperty("visionWardsBoughtInGame")]
        public long VisionWardsBoughtInGame { get; set; }
        [JsonProperty("wardsKilled")]
        public long WardsKilled { get; set; }
        [JsonProperty("wardsPlaced")]
        public long WardsPlaced { get; set; }
        [JsonProperty("win")]
        public bool Win { get; set; }
    }
}

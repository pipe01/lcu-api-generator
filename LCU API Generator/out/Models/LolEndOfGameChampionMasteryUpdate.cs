using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameChampionMasteryUpdate
    {
        [JsonProperty("bonusPointsGained")]
        public long BonusPointsGained { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("grade")]
        public string Grade { get; set; }
        [JsonProperty("hasLeveledUp")]
        public bool HasLeveledUp { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("level")]
        public long Level { get; set; }
        [JsonProperty("levelUpList")]
        public LolEndOfGameChampionMasteryMini[] LevelUpList { get; set; }
        [JsonProperty("memberGrades")]
        public LolEndOfGameChampionMasteryGrade[] MemberGrades { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("pointsBeforeGame")]
        public long PointsBeforeGame { get; set; }
        [JsonProperty("pointsGained")]
        public long PointsGained { get; set; }
        [JsonProperty("pointsGainedIndividualContribution")]
        public long PointsGainedIndividualContribution { get; set; }
        [JsonProperty("pointsSinceLastLevelBeforeGame")]
        public long PointsSinceLastLevelBeforeGame { get; set; }
        [JsonProperty("pointsUntilNextLevelAfterGame")]
        public long PointsUntilNextLevelAfterGame { get; set; }
        [JsonProperty("pointsUntilNextLevelBeforeGame")]
        public long PointsUntilNextLevelBeforeGame { get; set; }
        [JsonProperty("score")]
        public long Score { get; set; }
    }
}

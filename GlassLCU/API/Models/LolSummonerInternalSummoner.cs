using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSummonerInternalSummoner
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("advancedTutorialFlag")]
        public bool AdvancedTutorialFlag { get; set; }
        [JsonProperty("displayEloQuestionaireFlag")]
        public bool DisplayEloQuestionaireFlag { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("helpFlag")]
        public bool HelpFlag { get; set; }
        [JsonProperty("internalName")]
        public string InternalName { get; set; }
        [JsonProperty("lastSeasonHighestRank")]
        public string LastSeasonHighestRank { get; set; }
        [JsonProperty("nameChangeFlag")]
        public bool NameChangeFlag { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("tutorialFlag")]
        public bool TutorialFlag { get; set; }
    }
}

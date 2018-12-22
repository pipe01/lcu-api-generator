using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PrivateSummonerDTO
    {
        [JsonProperty("acctId")]
        public long AcctId { get; set; }
        [JsonProperty("advancedTutorialFlag")]
        public bool AdvancedTutorialFlag { get; set; }
        [JsonProperty("displayEloQuestionaire")]
        public bool DisplayEloQuestionaire { get; set; }
        [JsonProperty("internalName")]
        public string InternalName { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nameChangeFlag")]
        public bool NameChangeFlag { get; set; }
        [JsonProperty("previousSeasonHighestTier")]
        public string PreviousSeasonHighestTier { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("sumId")]
        public long SumId { get; set; }
        [JsonProperty("tutorialFlag")]
        public bool TutorialFlag { get; set; }
    }
}

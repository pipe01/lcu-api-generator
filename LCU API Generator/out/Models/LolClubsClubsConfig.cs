using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubsConfig
    {
        [JsonProperty("clubDescriptionMaxLength")]
        public int ClubDescriptionMaxLength { get; set; }
        [JsonProperty("clubMotdMaxLength")]
        public int ClubMotdMaxLength { get; set; }
        [JsonProperty("clubNominationsEnabled")]
        public bool ClubNominationsEnabled { get; set; }
        [JsonProperty("clubNominationsMaxPending")]
        public int ClubNominationsMaxPending { get; set; }
        [JsonProperty("clubTagRequirementMinGames")]
        public int ClubTagRequirementMinGames { get; set; }
        [JsonProperty("clubTagRequirementMinMembers")]
        public int ClubTagRequirementMinMembers { get; set; }
        [JsonProperty("clubTagRequirementsMinMemberLevel")]
        public int ClubTagRequirementsMinMemberLevel { get; set; }
        [JsonProperty("maxActiveClubs")]
        public int MaxActiveClubs { get; set; }
        [JsonProperty("maxClubNameLength")]
        public int MaxClubNameLength { get; set; }
        [JsonProperty("maxClubTagLength")]
        public int MaxClubTagLength { get; set; }
        [JsonProperty("minClubNameLength")]
        public int MinClubNameLength { get; set; }
        [JsonProperty("minClubTagLength")]
        public int MinClubTagLength { get; set; }
    }
}

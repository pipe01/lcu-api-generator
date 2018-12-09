using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMissionsRewardGroupsSelection
    {
        [JsonProperty("rewardGroups")]
        public string[] RewardGroups { get; set; }
    }
}

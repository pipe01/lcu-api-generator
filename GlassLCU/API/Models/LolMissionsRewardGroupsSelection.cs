using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMissionsRewardGroupsSelection
    {
        [JsonProperty("rewardGroups")]
        public string[] RewardGroups { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeRewardsRequirements
    {
        [JsonProperty("day")]
        public int Day { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("missionInternalName")]
        public string MissionInternalName { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
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

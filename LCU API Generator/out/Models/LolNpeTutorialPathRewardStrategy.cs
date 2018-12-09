using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathRewardStrategy
    {
        [JsonProperty("groupStrategy")]
        public string GroupStrategy { get; set; }
        [JsonProperty("selectMaxGroupCount")]
        public int SelectMaxGroupCount { get; set; }
        [JsonProperty("selectMinGroupCount")]
        public int SelectMinGroupCount { get; set; }
    }
}

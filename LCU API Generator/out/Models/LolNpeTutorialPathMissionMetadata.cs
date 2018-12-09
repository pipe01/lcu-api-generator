using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathMissionMetadata
    {
        [JsonProperty("tutorial")]
        public LolNpeTutorialPathTutorialMetadata Tutorial { get; set; }
    }
}

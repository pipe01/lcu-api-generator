using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MissionMetadata
    {
        [JsonProperty("tutorial")]
        public TutorialMetadata Tutorial { get; set; }
    }
}

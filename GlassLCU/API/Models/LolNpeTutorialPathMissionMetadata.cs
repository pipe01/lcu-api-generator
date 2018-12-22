using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathMissionMetadata
    {
        [JsonProperty("tutorial")]
        public LolNpeTutorialPathTutorialMetadata Tutorial { get; set; }
    }
}

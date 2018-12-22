using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MissionMetadata
    {
        [JsonProperty("tutorial")]
        public TutorialMetadata Tutorial { get; set; }
    }
}

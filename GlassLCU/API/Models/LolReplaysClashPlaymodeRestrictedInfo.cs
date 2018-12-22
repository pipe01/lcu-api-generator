using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolReplaysClashPlaymodeRestrictedInfo
    {
        [JsonProperty("isRestricted")]
        public bool IsRestricted { get; set; }
    }
}

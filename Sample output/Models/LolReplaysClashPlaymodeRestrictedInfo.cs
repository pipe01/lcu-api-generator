using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolReplaysClashPlaymodeRestrictedInfo
    {
        [JsonProperty("isRestricted")]
        public bool IsRestricted { get; set; }
    }
}

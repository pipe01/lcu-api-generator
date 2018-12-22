using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaRankedPositionInfo
    {
        [JsonProperty("division")]
        public LolRegaliaLeagueDivision Division { get; set; }
        [JsonProperty("isProvisional")]
        public bool IsProvisional { get; set; }
        [JsonProperty("position")]
        public LolRegaliaRankedPosition Position { get; set; }
        [JsonProperty("queueType")]
        public LolRegaliaLeagueQueueType QueueType { get; set; }
        [JsonProperty("tier")]
        public LolRegaliaLeagueTier Tier { get; set; }
    }
}

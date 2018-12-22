using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectLegacyChampSelectBannedChampions
    {
        [JsonProperty("myTeamBans")]
        public int[] MyTeamBans { get; set; }
        [JsonProperty("numBans")]
        public int NumBans { get; set; }
        [JsonProperty("theirTeamBans")]
        public int[] TheirTeamBans { get; set; }
    }
}

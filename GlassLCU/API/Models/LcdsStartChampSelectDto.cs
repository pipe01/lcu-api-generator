using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsStartChampSelectDto
    {
        [JsonProperty("invalidPlayers")]
        public LcdsFailedJoinPlayer[] InvalidPlayers { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsStartChampSelectDto
    {
        [JsonProperty("invalidPlayers")]
        public LcdsFailedJoinPlayer[] InvalidPlayers { get; set; }
    }
}

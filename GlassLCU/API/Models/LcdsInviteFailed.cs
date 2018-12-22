using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsInviteFailed
    {
        [JsonProperty("exception")]
        public LcdsGameInviteBaseRuntimeException Exception { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
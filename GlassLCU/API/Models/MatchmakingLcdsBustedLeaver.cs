using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MatchmakingLcdsBustedLeaver
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("leaverPenaltyMillisRemaining")]
        public long LeaverPenaltyMillisRemaining { get; set; }
        [JsonProperty("reasonFailed")]
        public string ReasonFailed { get; set; }
        [JsonProperty("summoner")]
        public MatchmakingLcdsSummoner Summoner { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathParticipant
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("stats")]
        public LolNpeTutorialPathParticipantStatistics Stats { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
    }
}

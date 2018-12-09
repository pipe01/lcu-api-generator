using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathMatchHistoryGame
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("participantIdentities")]
        public LolNpeTutorialPathParticipantIdentities[] ParticipantIdentities { get; set; }
        [JsonProperty("participants")]
        public LolNpeTutorialPathParticipant[] Participants { get; set; }
        [JsonProperty("teams")]
        public LolNpeTutorialPathTeam[] Teams { get; set; }
    }
}
